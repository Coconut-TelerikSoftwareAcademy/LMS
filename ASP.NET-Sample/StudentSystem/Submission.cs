using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Submission
    {
        public User user { get; private set; }
        public string sourceCode { get; private set; }
        public string sourceLang { get; private set; }
        public Task task;


        public Submission(User user, string sourceLang, string sourceCode, Task task)
        {
            this.user = user;
            this.sourceLang = sourceLang;
            this.sourceCode = sourceCode;
            this.task = task;
        }
    }
}