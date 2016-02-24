using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Showing
    {
        private int id;
        private string title;
        private string description;
        private DateTime premiere;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public DateTime Premiere
        {
            set { premiere = value; }
            get { return premiere; }
        }
    }
}
