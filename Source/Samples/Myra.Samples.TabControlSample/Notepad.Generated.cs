/* Generated by Myra UI Editor at 1/2/2018 5:33:48 PM */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Samples.TabControlSample
{
	partial class Notepad
	{
		private void BuildUI()
		{
			menuItemNew = new MenuItem();
			menuItemNew.Id = "menuItemNew";
			menuItemNew.Text = "New";

			menuItemOpen = new MenuItem();
			menuItemOpen.Id = "menuItemOpen";
			menuItemOpen.Text = "Open...";

			menuItemSave = new MenuItem();
			menuItemSave.Id = "menuItemSave";
			menuItemSave.Text = "Save";

			menuItemSaveAs = new MenuItem();
			menuItemSaveAs.Id = "menuItemSaveAs";
			menuItemSaveAs.Text = "Save As...";

			var menuSeparator1 = new MenuSeparator();

			menuItemQuit = new MenuItem();
			menuItemQuit.Id = "menuItemQuit";
			menuItemQuit.Text = "Quit";

			menuItemFile = new MenuItem();
			menuItemFile.Id = "menuItemFile";
			menuItemFile.Text = "File";
			menuItemFile.Items.Add(menuItemNew);
			menuItemFile.Items.Add(menuItemOpen);
			menuItemFile.Items.Add(menuItemSave);
			menuItemFile.Items.Add(menuItemSaveAs);
			menuItemFile.Items.Add(menuSeparator1);
			menuItemFile.Items.Add(menuItemQuit);

			menuItemAbout = new MenuItem();
			menuItemAbout.Id = "menuItemAbout";
			menuItemAbout.Text = "About";

			menuItemHelp = new MenuItem();
			menuItemHelp.Id = "menuItemHelp";
			menuItemHelp.Text = "Help";
			menuItemHelp.Items.Add(menuItemAbout);

			mainMenu = new HorizontalMenu();
			mainMenu.DrawLinesColor = Color.White;
			mainMenu.Id = "mainMenu";
			mainMenu.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			mainMenu.Items.Add(menuItemFile);
			mainMenu.Items.Add(menuItemHelp);

			textArea = new TextField();
			textArea.Text = "";
			textArea.TextColor = Color.White;
			textArea.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textArea.MessageTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textArea.Multiline = true;
			textArea.Id = "textArea";
			textArea.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			textArea.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			textArea.CanFocus = true;

			var scrollPane1 = new ScrollPane();
			scrollPane1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			scrollPane1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			scrollPane1.GridPositionY = 1;
			scrollPane1.ClipToBounds = true;
			scrollPane1.CanFocus = true;
			scrollPane1.Child = textArea;

			
			DrawLinesColor = Color.White;
			RowsProportions.Add(new Proportion());
			RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			Id = "Root";
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			Widgets.Add(mainMenu);
			Widgets.Add(scrollPane1);
		}

		
		public MenuItem menuItemNew;
		public MenuItem menuItemOpen;
		public MenuItem menuItemSave;
		public MenuItem menuItemSaveAs;
		public MenuItem menuItemQuit;
		public MenuItem menuItemFile;
		public MenuItem menuItemAbout;
		public MenuItem menuItemHelp;
		public HorizontalMenu mainMenu;
		public TextField textArea;
	}
}