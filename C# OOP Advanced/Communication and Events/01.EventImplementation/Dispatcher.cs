using System;
using System.Collections.Generic;
using System.Text;

namespace _01.EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                this.OnNameChange(new NameChangeEventArgs(value));
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            if (args != null)
                this.NameChange(this, args);
        }
    }


}

