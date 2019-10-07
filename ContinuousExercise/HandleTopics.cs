using System;
using System.Collections.Generic;
using System.Text;

namespace ContinuousExercise
{
    class HandleTopics
    {
        List<Topic> topics { get; set; }

        public HandleTopics(List<Topic> topics)
        {
            this.topics = topics;
        }

        public HandleTopics()
        {      
            topics = new List<Topic>();
        }

        public void add(Topic topic)
        {
            topics.Add(topic);      
        }
    }
}
