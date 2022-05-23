using System.Collections.Generic;
using System.Windows.Forms;

namespace TestClient
{
    public class VisualQuestion
    {
        public int MyProperty { get; set; }
        public FlowLayoutPanel flowPanelAnswer { get; set; }
        public List<CheckBox> checkBoxes { get; set; }
        public List<RadioButton> radioButtons { get; set; }


    }
}