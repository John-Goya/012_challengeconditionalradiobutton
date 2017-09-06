using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default_CC_Radiobutton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            if (pencilRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://raw.githubusercontent.com/John-Goya/012_challengeconditionalradiobutton/master/ChallengeConditionalRadioButton/images/pencil.png";
                resultLabel.Text = "You selected Pencil.";
            }
            else if (penRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://raw.githubusercontent.com/John-Goya/012_challengeconditionalradiobutton/master/ChallengeConditionalRadioButton/images/pen.png";
                resultLabel.Text = "You selected Pen.";
            }
            else if (phoneRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://raw.githubusercontent.com/John-Goya/012_challengeconditionalradiobutton/master/ChallengeConditionalRadioButton/images/phone.png";
                resultLabel.Text = "You selected Phone.";
            }
            else if (tabletRadioButton.Checked)
            {
                prefImage.ImageUrl = "https://raw.githubusercontent.com/John-Goya/012_challengeconditionalradiobutton/master/ChallengeConditionalRadioButton/images/tablet.png";
                resultLabel.Text = "You selected Tablet.";
            }
            else
            {
                resultLabel.Text = "Select an option.";
            }


        }
    }
}
