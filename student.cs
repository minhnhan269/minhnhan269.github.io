using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AppOOP
{
    class Student
    {
        private string Name;
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public Student() { }
        public Student(string stName)
        {
            Name = stName;
        }
        public virtual void Talk()
        {
            MessageBox.Show(Name);
        }
        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            Student st1 = new Student("Minh");
            st1.Talk();
            Student st2 = new Student();
            st2.StudentName = "Dung";
            st2.Talk();
        }
    }
}
