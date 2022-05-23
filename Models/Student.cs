using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public List<Evaluation> GetEvaluations()
        {
            return EvaluationRepository.GetEvaluations(this);
        }

        public int CalculateTotalPoints()
        {
            int totalPoints = 0;
            foreach (var evaluation in GetEvaluations())
            {
                totalPoints += evaluation.Points;
            }
            return totalPoints;
        }

        public bool HasSignature()
        {
            if (IsEvaluationComplete())
            {
                foreach (var evaluation in GetEvaluations())
                {
                    if (!evaluation.IsSufficientForSignature())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public bool HasGrade()
        {
            if (IsEvaluationComplete())
            {
                foreach (var evaluation in GetEvaluations())
                {
                    if (!evaluation.IsSufficientForGrade())
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public int CalculateGrade()
        {
            if (HasGrade())
            {
                int totalPoints = CalculateTotalPoints();

                if (totalPoints >= 91) return 5;
                else if (totalPoints >= 76) return 4;
                else if (totalPoints >= 61) return 3;
                else if (totalPoints >= 50) return 2;
                else return 1;
            }
            return 0;
        }

        private bool IsEvaluationComplete()
        {
            var evaluations = GetEvaluations();
            var activities = ActivityRepository.GetActivities();

            return evaluations.Count == activities.Count;
        }
    }
}
