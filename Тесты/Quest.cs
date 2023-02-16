using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тесты 
{ 
    public partial class Quest : Component
    {
        public Quest()
        {
            InitializeComponent();
        }

        public Quest(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

       
    }
}
