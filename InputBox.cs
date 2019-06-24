using System;
using System.Windows.Forms;

namespace TicTacToe
{
	public class InputBox : System.Windows.Forms.Form
	{

		#region Form Inicialization 
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label lbTexto;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
		private System.ComponentModel.Container components = null;

		private InputBox()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Location = new System.Drawing.Point(12, 41);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(297, 20);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "txtText";
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // lbTexto
            // 
            this.lbTexto.Location = new System.Drawing.Point(12, 9);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(297, 29);
            this.lbTexto.TabIndex = 1;
            this.lbTexto.Text = "text";
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btOK.Location = new System.Drawing.Point(234, 85);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancel.Location = new System.Drawing.Point(153, 85);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            // 
            // InputBox
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(321, 120);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region InputBox 
 
		private void txtText_KeyDown(object sender,System.Windows.Forms.KeyEventArgs e)
		{
			//_____________________________________________________________________________________________
			//
			// Enter sends OK and close the dialog
			//_____________________________________________________________________________________________

			if (e.KeyCode == Keys.Enter)
			{
				this.DialogResult=DialogResult.OK;
				this.Close();
			}
		}


		public static DialogResult ShowInputBox(string Prompt,string Title,string Default,ref string Return)
		{
			//_____________________________________________________________________________________________
			//
			// Creates the dialog object and configure it
			//_____________________________________________________________________________________________

			InputBox box = new InputBox();

			box.txtText.Text=Default;
			box.lbTexto.Text=Prompt;
			box.Text=Title;

			//_____________________________________________________________________________________________
			//
			// Shows inputbox as a modal dialog
			//_____________________________________________________________________________________________

			DialogResult wDialogResult=box.ShowDialog();

			//_____________________________________________________________________________________________
			//
			// Configures dialog and text return in case of OK or CANCEL is selected
			//_____________________________________________________________________________________________

			if (wDialogResult==DialogResult.OK)
				Return=box.txtText.Text;
			else
				Return="";

			return wDialogResult;
		}


        #endregion
    }
}
