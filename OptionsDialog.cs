using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Reversi
{
	/// <summary>
	/// Summary description for OptionsDialog.
	/// </summary>
	public class OptionsDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl optionsTabControl;
		private System.Windows.Forms.TabPage displayTabPage;
		private System.Windows.Forms.CheckBox showValidMovesCheckBox;
		private System.Windows.Forms.CheckBox previewMovesCheckBox;
		private System.Windows.Forms.CheckBox animateMovesCheckBox;
		private System.Windows.Forms.Label boardColorLabel;
		private System.Windows.Forms.Panel boardColorPanel;
		private System.Windows.Forms.Button boardColorButton;
		private System.Windows.Forms.Label validColorLabel;
		private System.Windows.Forms.Panel validColorPanel;
		private System.Windows.Forms.Button validColorButton;
		private System.Windows.Forms.Label activeColorLabel;
		private System.Windows.Forms.Panel activeColorPanel;
		private System.Windows.Forms.Button activeColorButton;
		private System.Windows.Forms.Label moveIndicatorColorLabel;
		private System.Windows.Forms.Panel moveIndicatorColorPanel;
		private System.Windows.Forms.Button moveIndicatorColorButton;
		private System.Windows.Forms.Label firstMoveLabel;
		private System.Windows.Forms.Panel firstMovePanel;
		private System.Windows.Forms.RadioButton firstMoveBlackRadioButton;
		private System.Windows.Forms.RadioButton firstMoveWhiteRadioButton;
		private System.Windows.Forms.TabPage playersTabPage;
		private System.Windows.Forms.Panel blackPlayerPanel;
		private System.Windows.Forms.RadioButton blackPlayerComputerRadioButton;
		private System.Windows.Forms.RadioButton blackPlayerUserRadioButton;
		private System.Windows.Forms.Panel whitePlayerPanel;
		private System.Windows.Forms.RadioButton whitePlayerComputerRadioButton;
		private System.Windows.Forms.RadioButton whitePlayerUserRadioButton;
		private System.Windows.Forms.Label blackPlayerLabel;
		private System.Windows.Forms.Label whitePlayerLabel;
		private System.Windows.Forms.TabPage difficultyTabPage;
		private System.Windows.Forms.Panel difficultyPanel;
		private System.Windows.Forms.RadioButton beginnerRadioButton;
		private System.Windows.Forms.RadioButton intermediateRadioButton;
		private System.Windows.Forms.RadioButton advancedRadioButton;
		private System.Windows.Forms.RadioButton expertRadioButton;
		private System.Windows.Forms.Button restoreDefaultsButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 
		private System.ComponentModel.Container components = null;

		// The game options.
		public Options Options;

		// An array to store custom colors added by the user.
		private static int[] customColors = new int[] {};

		public OptionsDialog(Options options)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			// Create a copy of the given game options.
			this.Options = new Options(options);

			// Set the form controls based on those options.
			this.MapOptionsToControls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.displayTabPage = new System.Windows.Forms.TabPage();
            this.previewMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.moveIndicatorColorButton = new System.Windows.Forms.Button();
            this.moveIndicatorColorPanel = new System.Windows.Forms.Panel();
            this.moveIndicatorColorLabel = new System.Windows.Forms.Label();
            this.animateMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.validColorButton = new System.Windows.Forms.Button();
            this.validColorPanel = new System.Windows.Forms.Panel();
            this.validColorLabel = new System.Windows.Forms.Label();
            this.activeColorButton = new System.Windows.Forms.Button();
            this.activeColorPanel = new System.Windows.Forms.Panel();
            this.activeColorLabel = new System.Windows.Forms.Label();
            this.boardColorButton = new System.Windows.Forms.Button();
            this.boardColorPanel = new System.Windows.Forms.Panel();
            this.boardColorLabel = new System.Windows.Forms.Label();
            this.showValidMovesCheckBox = new System.Windows.Forms.CheckBox();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.whitePlayerPanel = new System.Windows.Forms.Panel();
            this.whitePlayerUserRadioButton = new System.Windows.Forms.RadioButton();
            this.whitePlayerComputerRadioButton = new System.Windows.Forms.RadioButton();
            this.whitePlayerLabel = new System.Windows.Forms.Label();
            this.blackPlayerPanel = new System.Windows.Forms.Panel();
            this.blackPlayerUserRadioButton = new System.Windows.Forms.RadioButton();
            this.blackPlayerComputerRadioButton = new System.Windows.Forms.RadioButton();
            this.blackPlayerLabel = new System.Windows.Forms.Label();
            this.firstMovePanel = new System.Windows.Forms.Panel();
            this.firstMoveWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.firstMoveBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.firstMoveLabel = new System.Windows.Forms.Label();
            this.difficultyTabPage = new System.Windows.Forms.TabPage();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.expertRadioButton = new System.Windows.Forms.RadioButton();
            this.advancedRadioButton = new System.Windows.Forms.RadioButton();
            this.intermediateRadioButton = new System.Windows.Forms.RadioButton();
            this.beginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.restoreDefaultsButton = new System.Windows.Forms.Button();
            this.optionsTabControl.SuspendLayout();
            this.displayTabPage.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            this.whitePlayerPanel.SuspendLayout();
            this.blackPlayerPanel.SuspendLayout();
            this.firstMovePanel.SuspendLayout();
            this.difficultyTabPage.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.displayTabPage);
            this.optionsTabControl.Controls.Add(this.playersTabPage);
            this.optionsTabControl.Controls.Add(this.difficultyTabPage);
            this.optionsTabControl.Location = new System.Drawing.Point(10, 18);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(486, 250);
            this.optionsTabControl.TabIndex = 0;
            // 
            // displayTabPage
            // 
            this.displayTabPage.Controls.Add(this.previewMovesCheckBox);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorButton);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorPanel);
            this.displayTabPage.Controls.Add(this.moveIndicatorColorLabel);
            this.displayTabPage.Controls.Add(this.animateMovesCheckBox);
            this.displayTabPage.Controls.Add(this.validColorButton);
            this.displayTabPage.Controls.Add(this.validColorPanel);
            this.displayTabPage.Controls.Add(this.validColorLabel);
            this.displayTabPage.Controls.Add(this.activeColorButton);
            this.displayTabPage.Controls.Add(this.activeColorPanel);
            this.displayTabPage.Controls.Add(this.activeColorLabel);
            this.displayTabPage.Controls.Add(this.boardColorButton);
            this.displayTabPage.Controls.Add(this.boardColorPanel);
            this.displayTabPage.Controls.Add(this.boardColorLabel);
            this.displayTabPage.Controls.Add(this.showValidMovesCheckBox);
            this.displayTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.displayTabPage.Location = new System.Drawing.Point(4, 25);
            this.displayTabPage.Name = "displayTabPage";
            this.displayTabPage.Size = new System.Drawing.Size(478, 221);
            this.displayTabPage.TabIndex = 0;
            this.displayTabPage.Text = "Відображення";
            // 
            // previewMovesCheckBox
            // 
            this.previewMovesCheckBox.Location = new System.Drawing.Point(321, 12);
            this.previewMovesCheckBox.Name = "previewMovesCheckBox";
            this.previewMovesCheckBox.Size = new System.Drawing.Size(125, 27);
            this.previewMovesCheckBox.TabIndex = 1;
            this.previewMovesCheckBox.Text = "Попередній перегляд ходів";
            // 
            // moveIndicatorColorButton
            // 
            this.moveIndicatorColorButton.Location = new System.Drawing.Point(356, 182);
            this.moveIndicatorColorButton.Name = "moveIndicatorColorButton";
            this.moveIndicatorColorButton.Size = new System.Drawing.Size(90, 27);
            this.moveIndicatorColorButton.TabIndex = 14;
            this.moveIndicatorColorButton.Text = "Обрати...";
            this.moveIndicatorColorButton.Click += new System.EventHandler(this.moveIndicatorColorButton_Click);
            // 
            // moveIndicatorColorPanel
            // 
            this.moveIndicatorColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveIndicatorColorPanel.Location = new System.Drawing.Point(279, 187);
            this.moveIndicatorColorPanel.Name = "moveIndicatorColorPanel";
            this.moveIndicatorColorPanel.Size = new System.Drawing.Size(19, 18);
            this.moveIndicatorColorPanel.TabIndex = 13;
            // 
            // moveIndicatorColorLabel
            // 
            this.moveIndicatorColorLabel.AutoSize = true;
            this.moveIndicatorColorLabel.Location = new System.Drawing.Point(32, 187);
            this.moveIndicatorColorLabel.Name = "moveIndicatorColorLabel";
            this.moveIndicatorColorLabel.Size = new System.Drawing.Size(208, 16);
            this.moveIndicatorColorLabel.TabIndex = 12;
            this.moveIndicatorColorLabel.Text = "Колір індикатора переміщення:";
            // 
            // animateMovesCheckBox
            // 
            this.animateMovesCheckBox.Location = new System.Drawing.Point(41, 40);
            this.animateMovesCheckBox.Name = "animateMovesCheckBox";
            this.animateMovesCheckBox.Size = new System.Drawing.Size(125, 27);
            this.animateMovesCheckBox.TabIndex = 2;
            this.animateMovesCheckBox.Text = "Анімація рухів";
            // 
            // validColorButton
            // 
            this.validColorButton.Location = new System.Drawing.Point(356, 108);
            this.validColorButton.Name = "validColorButton";
            this.validColorButton.Size = new System.Drawing.Size(90, 27);
            this.validColorButton.TabIndex = 8;
            this.validColorButton.Text = "Обрати...";
            this.validColorButton.Click += new System.EventHandler(this.validColorButton_Click);
            // 
            // validColorPanel
            // 
            this.validColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validColorPanel.Location = new System.Drawing.Point(279, 111);
            this.validColorPanel.Name = "validColorPanel";
            this.validColorPanel.Size = new System.Drawing.Size(19, 18);
            this.validColorPanel.TabIndex = 7;
            // 
            // validColorLabel
            // 
            this.validColorLabel.AutoSize = true;
            this.validColorLabel.Location = new System.Drawing.Point(54, 113);
            this.validColorLabel.Name = "validColorLabel";
            this.validColorLabel.Size = new System.Drawing.Size(131, 16);
            this.validColorLabel.TabIndex = 6;
            this.validColorLabel.Text = "Дійсний колір ходу:";
            // 
            // activeColorButton
            // 
            this.activeColorButton.Location = new System.Drawing.Point(356, 145);
            this.activeColorButton.Name = "activeColorButton";
            this.activeColorButton.Size = new System.Drawing.Size(90, 27);
            this.activeColorButton.TabIndex = 11;
            this.activeColorButton.Text = "Обрати...";
            this.activeColorButton.Click += new System.EventHandler(this.activeColorButton_Click);
            // 
            // activeColorPanel
            // 
            this.activeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeColorPanel.Location = new System.Drawing.Point(279, 148);
            this.activeColorPanel.Name = "activeColorPanel";
            this.activeColorPanel.Size = new System.Drawing.Size(19, 18);
            this.activeColorPanel.TabIndex = 10;
            // 
            // activeColorLabel
            // 
            this.activeColorLabel.AutoSize = true;
            this.activeColorLabel.Location = new System.Drawing.Point(38, 150);
            this.activeColorLabel.Name = "activeColorLabel";
            this.activeColorLabel.Size = new System.Drawing.Size(181, 16);
            this.activeColorLabel.TabIndex = 9;
            this.activeColorLabel.Text = "Колір активного квадрату:";
            // 
            // boardColorButton
            // 
            this.boardColorButton.Location = new System.Drawing.Point(356, 71);
            this.boardColorButton.Name = "boardColorButton";
            this.boardColorButton.Size = new System.Drawing.Size(90, 27);
            this.boardColorButton.TabIndex = 5;
            this.boardColorButton.Text = "Обрати...";
            this.boardColorButton.Click += new System.EventHandler(this.boardColorButton_Click);
            // 
            // boardColorPanel
            // 
            this.boardColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardColorPanel.Location = new System.Drawing.Point(279, 74);
            this.boardColorPanel.Name = "boardColorPanel";
            this.boardColorPanel.Size = new System.Drawing.Size(19, 18);
            this.boardColorPanel.TabIndex = 4;
            // 
            // boardColorLabel
            // 
            this.boardColorLabel.AutoSize = true;
            this.boardColorLabel.Location = new System.Drawing.Point(85, 76);
            this.boardColorLabel.Name = "boardColorLabel";
            this.boardColorLabel.Size = new System.Drawing.Size(88, 16);
            this.boardColorLabel.TabIndex = 3;
            this.boardColorLabel.Text = "Колір дошки:";
            // 
            // showValidMovesCheckBox
            // 
            this.showValidMovesCheckBox.Location = new System.Drawing.Point(41, 12);
            this.showValidMovesCheckBox.Name = "showValidMovesCheckBox";
            this.showValidMovesCheckBox.Size = new System.Drawing.Size(144, 27);
            this.showValidMovesCheckBox.TabIndex = 0;
            this.showValidMovesCheckBox.Text = "Відображення дійсного ходу";
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.whitePlayerPanel);
            this.playersTabPage.Controls.Add(this.blackPlayerPanel);
            this.playersTabPage.Controls.Add(this.firstMovePanel);
            this.playersTabPage.Location = new System.Drawing.Point(4, 25);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Size = new System.Drawing.Size(478, 221);
            this.playersTabPage.TabIndex = 1;
            this.playersTabPage.Text = "Гравці";
            // 
            // whitePlayerPanel
            // 
            this.whitePlayerPanel.Controls.Add(this.whitePlayerUserRadioButton);
            this.whitePlayerPanel.Controls.Add(this.whitePlayerComputerRadioButton);
            this.whitePlayerPanel.Controls.Add(this.whitePlayerLabel);
            this.whitePlayerPanel.Location = new System.Drawing.Point(48, 147);
            this.whitePlayerPanel.Name = "whitePlayerPanel";
            this.whitePlayerPanel.Size = new System.Drawing.Size(376, 64);
            this.whitePlayerPanel.TabIndex = 5;
            // 
            // whitePlayerUserRadioButton
            // 
            this.whitePlayerUserRadioButton.Location = new System.Drawing.Point(169, 31);
            this.whitePlayerUserRadioButton.Name = "whitePlayerUserRadioButton";
            this.whitePlayerUserRadioButton.Size = new System.Drawing.Size(124, 28);
            this.whitePlayerUserRadioButton.TabIndex = 1;
            this.whitePlayerUserRadioButton.Text = "Користувач";
            // 
            // whitePlayerComputerRadioButton
            // 
            this.whitePlayerComputerRadioButton.Location = new System.Drawing.Point(169, 8);
            this.whitePlayerComputerRadioButton.Name = "whitePlayerComputerRadioButton";
            this.whitePlayerComputerRadioButton.Size = new System.Drawing.Size(124, 28);
            this.whitePlayerComputerRadioButton.TabIndex = 0;
            this.whitePlayerComputerRadioButton.Text = "Комп\'ютер";
            // 
            // whitePlayerLabel
            // 
            this.whitePlayerLabel.AutoSize = true;
            this.whitePlayerLabel.Location = new System.Drawing.Point(10, 14);
            this.whitePlayerLabel.Name = "whitePlayerLabel";
            this.whitePlayerLabel.Size = new System.Drawing.Size(102, 16);
            this.whitePlayerLabel.TabIndex = 4;
            this.whitePlayerLabel.Text = "Білий гравець:";
            // 
            // blackPlayerPanel
            // 
            this.blackPlayerPanel.Controls.Add(this.blackPlayerUserRadioButton);
            this.blackPlayerPanel.Controls.Add(this.blackPlayerComputerRadioButton);
            this.blackPlayerPanel.Controls.Add(this.blackPlayerLabel);
            this.blackPlayerPanel.Location = new System.Drawing.Point(48, 77);
            this.blackPlayerPanel.Name = "blackPlayerPanel";
            this.blackPlayerPanel.Size = new System.Drawing.Size(376, 65);
            this.blackPlayerPanel.TabIndex = 3;
            // 
            // blackPlayerUserRadioButton
            // 
            this.blackPlayerUserRadioButton.Location = new System.Drawing.Point(169, 31);
            this.blackPlayerUserRadioButton.Name = "blackPlayerUserRadioButton";
            this.blackPlayerUserRadioButton.Size = new System.Drawing.Size(124, 28);
            this.blackPlayerUserRadioButton.TabIndex = 1;
            this.blackPlayerUserRadioButton.Text = "Користувач";
            // 
            // blackPlayerComputerRadioButton
            // 
            this.blackPlayerComputerRadioButton.Location = new System.Drawing.Point(169, 8);
            this.blackPlayerComputerRadioButton.Name = "blackPlayerComputerRadioButton";
            this.blackPlayerComputerRadioButton.Size = new System.Drawing.Size(124, 28);
            this.blackPlayerComputerRadioButton.TabIndex = 0;
            this.blackPlayerComputerRadioButton.Text = "Комп\'ютер";
            // 
            // blackPlayerLabel
            // 
            this.blackPlayerLabel.AutoSize = true;
            this.blackPlayerLabel.Location = new System.Drawing.Point(11, 14);
            this.blackPlayerLabel.Name = "blackPlayerLabel";
            this.blackPlayerLabel.Size = new System.Drawing.Size(115, 16);
            this.blackPlayerLabel.TabIndex = 2;
            this.blackPlayerLabel.Text = "Чорний гравець:";
            // 
            // firstMovePanel
            // 
            this.firstMovePanel.Controls.Add(this.firstMoveWhiteRadioButton);
            this.firstMovePanel.Controls.Add(this.firstMoveBlackRadioButton);
            this.firstMovePanel.Controls.Add(this.firstMoveLabel);
            this.firstMovePanel.Location = new System.Drawing.Point(48, 8);
            this.firstMovePanel.Name = "firstMovePanel";
            this.firstMovePanel.Size = new System.Drawing.Size(376, 65);
            this.firstMovePanel.TabIndex = 1;
            // 
            // firstMoveWhiteRadioButton
            // 
            this.firstMoveWhiteRadioButton.Location = new System.Drawing.Point(169, 33);
            this.firstMoveWhiteRadioButton.Name = "firstMoveWhiteRadioButton";
            this.firstMoveWhiteRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstMoveWhiteRadioButton.TabIndex = 1;
            this.firstMoveWhiteRadioButton.Text = "Білий";
            // 
            // firstMoveBlackRadioButton
            // 
            this.firstMoveBlackRadioButton.Location = new System.Drawing.Point(169, 8);
            this.firstMoveBlackRadioButton.Name = "firstMoveBlackRadioButton";
            this.firstMoveBlackRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstMoveBlackRadioButton.TabIndex = 0;
            this.firstMoveBlackRadioButton.Text = "Чорний";
            // 
            // firstMoveLabel
            // 
            this.firstMoveLabel.AutoSize = true;
            this.firstMoveLabel.Location = new System.Drawing.Point(22, 14);
            this.firstMoveLabel.Name = "firstMoveLabel";
            this.firstMoveLabel.Size = new System.Drawing.Size(81, 16);
            this.firstMoveLabel.TabIndex = 0;
            this.firstMoveLabel.Text = "Перший хід:";
            // 
            // difficultyTabPage
            // 
            this.difficultyTabPage.Controls.Add(this.difficultyPanel);
            this.difficultyTabPage.Location = new System.Drawing.Point(4, 25);
            this.difficultyTabPage.Name = "difficultyTabPage";
            this.difficultyTabPage.Size = new System.Drawing.Size(478, 221);
            this.difficultyTabPage.TabIndex = 2;
            this.difficultyTabPage.Text = "Складність";
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.Controls.Add(this.expertRadioButton);
            this.difficultyPanel.Controls.Add(this.advancedRadioButton);
            this.difficultyPanel.Controls.Add(this.intermediateRadioButton);
            this.difficultyPanel.Controls.Add(this.beginnerRadioButton);
            this.difficultyPanel.Location = new System.Drawing.Point(175, 23);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(141, 175);
            this.difficultyPanel.TabIndex = 0;
            // 
            // expertRadioButton
            // 
            this.expertRadioButton.Location = new System.Drawing.Point(17, 129);
            this.expertRadioButton.Name = "expertRadioButton";
            this.expertRadioButton.Size = new System.Drawing.Size(105, 28);
            this.expertRadioButton.TabIndex = 3;
            this.expertRadioButton.Text = "Експерт";
            // 
            // advancedRadioButton
            // 
            this.advancedRadioButton.Location = new System.Drawing.Point(17, 92);
            this.advancedRadioButton.Name = "advancedRadioButton";
            this.advancedRadioButton.Size = new System.Drawing.Size(121, 28);
            this.advancedRadioButton.TabIndex = 2;
            this.advancedRadioButton.Text = "Просунутий";
            // 
            // intermediateRadioButton
            // 
            this.intermediateRadioButton.Location = new System.Drawing.Point(17, 55);
            this.intermediateRadioButton.Name = "intermediateRadioButton";
            this.intermediateRadioButton.Size = new System.Drawing.Size(105, 28);
            this.intermediateRadioButton.TabIndex = 1;
            this.intermediateRadioButton.Text = "Середній";
            // 
            // beginnerRadioButton
            // 
            this.beginnerRadioButton.Location = new System.Drawing.Point(17, 18);
            this.beginnerRadioButton.Name = "beginnerRadioButton";
            this.beginnerRadioButton.Size = new System.Drawing.Size(121, 28);
            this.beginnerRadioButton.TabIndex = 0;
            this.beginnerRadioButton.Text = "Початківець";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(306, 277);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 26);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(402, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 26);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Відміна";
            // 
            // restoreDefaultsButton
            // 
            this.restoreDefaultsButton.Location = new System.Drawing.Point(10, 277);
            this.restoreDefaultsButton.Name = "restoreDefaultsButton";
            this.restoreDefaultsButton.Size = new System.Drawing.Size(244, 26);
            this.restoreDefaultsButton.TabIndex = 3;
            this.restoreDefaultsButton.Text = "Відновити за замовчуванням";
            this.restoreDefaultsButton.Click += new System.EventHandler(this.restoreDefaultsButton_Click);
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.ControlBox = false;
            this.Controls.Add(this.restoreDefaultsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.optionsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Опції";
            this.optionsTabControl.ResumeLayout(false);
            this.displayTabPage.ResumeLayout(false);
            this.displayTabPage.PerformLayout();
            this.playersTabPage.ResumeLayout(false);
            this.whitePlayerPanel.ResumeLayout(false);
            this.whitePlayerPanel.PerformLayout();
            this.blackPlayerPanel.ResumeLayout(false);
            this.blackPlayerPanel.PerformLayout();
            this.firstMovePanel.ResumeLayout(false);
            this.firstMovePanel.PerformLayout();
            this.difficultyTabPage.ResumeLayout(false);
            this.difficultyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		//
		// Sets the form controls based on the current game options.
		//
		private void MapOptionsToControls()
		{
			this.showValidMovesCheckBox.Checked    = this.Options.ShowValidMoves;
			this.previewMovesCheckBox.Checked      = this.Options.PreviewMoves;
			this.animateMovesCheckBox.Checked      = this.Options.AnimateMoves;
			this.boardColorPanel.BackColor         = this.Options.BoardColor;
			this.validColorPanel.BackColor         = this.Options.ValidMoveColor;
			this.activeColorPanel.BackColor        = this.Options.ActiveSquareColor;
			this.moveIndicatorColorPanel.BackColor = this.Options.MoveIndicatorColor;

			if (this.Options.FirstMove == Board.Black)
				this.firstMoveBlackRadioButton.Checked = true;
			else
				this.firstMoveWhiteRadioButton.Checked  =  true;
			this.blackPlayerComputerRadioButton.Checked =  this.Options.ComputerPlaysBlack;
			this.blackPlayerUserRadioButton.Checked     = !this.Options.ComputerPlaysBlack;
			this.whitePlayerComputerRadioButton.Checked =  this.Options.ComputerPlaysWhite;
			this.whitePlayerUserRadioButton.Checked     = !this.Options.ComputerPlaysWhite;

			this.beginnerRadioButton.Checked     = (this.Options.Difficulty == ReversiForm.Difficulty.Beginner);
			this.intermediateRadioButton.Checked = (this.Options.Difficulty == ReversiForm.Difficulty.Intermediate);
			this.advancedRadioButton.Checked     = (this.Options.Difficulty == ReversiForm.Difficulty.Advanced);
			this.expertRadioButton.Checked       = (this.Options.Difficulty == ReversiForm.Difficulty.Expert);

			this.Refresh();
		}

		//
		// Sets the game options based on the current state of the form
		// controls.
		//
		private void MapControlsToOptions()
		{
			this.Options.ShowValidMoves     = this.showValidMovesCheckBox.Checked;
			this.Options.PreviewMoves       = this.previewMovesCheckBox.Checked;
			this.Options.AnimateMoves       = this.animateMovesCheckBox.Checked;
			this.Options.BoardColor         = this.boardColorPanel.BackColor;
			this.Options.ValidMoveColor     = this.validColorPanel.BackColor;
			this.Options.ActiveSquareColor  = this.activeColorPanel.BackColor;
			this.Options.MoveIndicatorColor = this.moveIndicatorColorPanel.BackColor;

			if (this.firstMoveBlackRadioButton.Checked)
				this.Options.FirstMove = Board.Black;
			else
				this.Options.FirstMove = Board.White;
			if (this.blackPlayerComputerRadioButton.Checked)
				this.Options.ComputerPlaysBlack = true;
			else
				this.Options.ComputerPlaysBlack = false;
			if (this.whitePlayerComputerRadioButton.Checked)
				this.Options.ComputerPlaysWhite = true;
			else
				this.Options.ComputerPlaysWhite = false;

			if (this.beginnerRadioButton.Checked)
				this.Options.Difficulty = ReversiForm.Difficulty.Beginner;
			else if (this.intermediateRadioButton.Checked)
				this.Options.Difficulty = ReversiForm.Difficulty.Intermediate;
			else if (this.advancedRadioButton.Checked)
				this.Options.Difficulty = ReversiForm.Difficulty.Advanced;
			else
				this.Options.Difficulty = ReversiForm.Difficulty.Expert;
		}

		// ===================================================================
		// Event handlers for the color select buttons.
		// ===================================================================

		private void boardColorButton_Click(object sender, System.EventArgs e)
		{
			// Open a color dialog.
			ColorDialog dlg = new ColorDialog();
			dlg.Color = this.boardColorPanel.BackColor;
			dlg.CustomColors = OptionsDialog.customColors;

			// Set the board color based on that selection.
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				this.boardColorPanel.BackColor = dlg.Color;
				this.boardColorPanel.Refresh();
				OptionsDialog.customColors = dlg.CustomColors;
			}
		}

		private void validColorButton_Click(object sender, System.EventArgs e)
		{
			// Open a color dialog.
			ColorDialog dlg = new ColorDialog();
			dlg.Color = this.validColorPanel.BackColor;
			dlg.CustomColors = OptionsDialog.customColors;

			// Set the valid move color based on that selection.
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				this.validColorPanel.BackColor = dlg.Color;
				this.validColorPanel.Refresh();
				OptionsDialog.customColors = dlg.CustomColors;
			}
		}

		private void activeColorButton_Click(object sender, System.EventArgs e)
		{
			// Open a color dialog.
			ColorDialog dlg = new ColorDialog();
			dlg.Color = this.activeColorPanel.BackColor;
			dlg.CustomColors = OptionsDialog.customColors;

			// Set the active square color based on that selection.
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				this.activeColorPanel.BackColor = dlg.Color;
				this.activeColorPanel.Refresh();
				OptionsDialog.customColors = dlg.CustomColors;
			}
		}

		private void moveIndicatorColorButton_Click(object sender, System.EventArgs e)
		{
			// Open a color dialog.
			ColorDialog dlg = new ColorDialog();
			dlg.Color = this.moveIndicatorColorPanel.BackColor;
			dlg.CustomColors = OptionsDialog.customColors;

			// Set the move indicator color based on that selection.
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				this.moveIndicatorColorPanel.BackColor = dlg.Color;
				this.moveIndicatorColorPanel.Refresh();
				OptionsDialog.customColors = dlg.CustomColors;
			}
		}

		// ===================================================================
		// Event handlers for the form buttons.
		// ===================================================================

		private void restoreDefaultsButton_Click(object sender, System.EventArgs e)
		{
			// Reset the game options to their defaults.
			this.Options.RestoreDefaults();

			// Update the form controls.
			this.MapOptionsToControls();
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			// Set game options based on the form control values.
			this.MapControlsToOptions();
		}
	}
}
