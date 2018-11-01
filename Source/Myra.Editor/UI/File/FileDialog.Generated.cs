/* Generated by Myra UI Editor at 03.11.2018 16:54:38 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Editor.UI.File
{
	partial class FileDialog
	{
		private void BuildUI()
		{
			_buttonBack = new ImageButton();
			_buttonBack.Id = "_buttonBack";
			_buttonBack.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonBack.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;

			_buttonForward = new ImageButton();
			_buttonForward.Id = "_buttonForward";
			_buttonForward.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonForward.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonForward.GridPositionX = 1;

			_textFieldPath = new TextField();
			_textFieldPath.Text = "";
			_textFieldPath.Readonly = true;
			_textFieldPath.Id = "_textFieldPath";
			_textFieldPath.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_textFieldPath.GridPositionX = 2;

			_buttonParent = new ImageButton();
			_buttonParent.Id = "_buttonParent";
			_buttonParent.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonParent.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonParent.GridPositionX = 3;

			var grid1 = new Grid();
			grid1.ColumnSpacing = 4;
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.Widgets.Add(_buttonBack);
			grid1.Widgets.Add(_buttonForward);
			grid1.Widgets.Add(_textFieldPath);
			grid1.Widgets.Add(_buttonParent);

			_listBoxPlaces = new ListBox();
			_listBoxPlaces.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			_listBoxPlaces.Id = "_listBoxPlaces";
			_listBoxPlaces.ClipToBounds = true;

			_gridFiles = new Grid();
			_gridFiles.ColumnSpacing = 4;
			_gridFiles.RowSpacing = 4;
			_gridFiles.ColumnsProportions.Add(new Grid.Proportion());
			_gridFiles.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			_gridFiles.GridSelectionMode = Myra.Graphics2D.UI.GridSelectionMode.Row;
			_gridFiles.Id = "_gridFiles";
			_gridFiles.CanFocus = true;

			_scrollPane = new ScrollPane();
			_scrollPane.AllowHorizontalScrolling = false;
			_scrollPane.Id = "_scrollPane";
			_scrollPane.GridPositionX = 2;
			_scrollPane.Child = _gridFiles;

			_splitPane = new HorizontalSplitPane();
			_splitPane.Id = "_splitPane";
			_splitPane.GridPositionY = 1;
			_splitPane.Widgets.Add(_listBoxPlaces);
			_splitPane.Widgets.Add(_scrollPane);

			_textBlockFileName = new TextBlock();
			_textBlockFileName.Text = "File name";
			_textBlockFileName.Id = "_textBlockFileName";

			_textFieldFileName = new TextField();
			_textFieldFileName.Text = "";
			_textFieldFileName.Id = "_textFieldFileName";
			_textFieldFileName.GridPositionX = 1;

			var grid2 = new Grid();
			grid2.ColumnSpacing = 4;
			grid2.ColumnsProportions.Add(new Grid.Proportion());
			grid2.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid2.GridPositionY = 2;
			grid2.Widgets.Add(_textBlockFileName);
			grid2.Widgets.Add(_textFieldFileName);

			var grid3 = new Grid();
			grid3.RowSpacing = 4;
			grid3.RowsProportions.Add(new Grid.Proportion());
			grid3.RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid3.RowsProportions.Add(new Grid.Proportion());
			grid3.GridPositionY = 1;
			grid3.Widgets.Add(grid1);
			grid3.Widgets.Add(_splitPane);
			grid3.Widgets.Add(grid2);

			
			Title = "Open File...";
			XHint = 144;
			YHint = 183;
			WidthHint = 600;
			HeightHint = 400;
			Content = grid3;
		}

		
		public ImageButton _buttonBack;
		public ImageButton _buttonForward;
		public TextField _textFieldPath;
		public ImageButton _buttonParent;
		public ListBox _listBoxPlaces;
		public Grid _gridFiles;
		public ScrollPane _scrollPane;
		public HorizontalSplitPane _splitPane;
		public TextBlock _textBlockFileName;
		public TextField _textFieldFileName;
	}
}