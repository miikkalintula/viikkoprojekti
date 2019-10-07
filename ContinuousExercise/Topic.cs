using System;
using System.Collections.Generic;
using System.Text;

namespace ContinuousExercise
{
    class Topic
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        double EstimatedTimeToMaster { get; set; }
        double TimeSpent { get; set; }
        string Source { get; set; }
        DateTime StartLearningDate { get; set; }
        bool InProgress { get; set; }
        DateTime CompletionDate { get; set; }

        public Topic(int id, string title, string description, double estimatedTimeToMaster, double timeSpent, string source, DateTime startLearningDate, bool inProgress, DateTime completionDate)
        {
            Id = id;
            Title = title;
            Description = description;
            EstimatedTimeToMaster = estimatedTimeToMaster;
            TimeSpent = timeSpent;
            Source = source;
            StartLearningDate = startLearningDate;
            InProgress = inProgress;
            CompletionDate = completionDate;
        }
    }
}
