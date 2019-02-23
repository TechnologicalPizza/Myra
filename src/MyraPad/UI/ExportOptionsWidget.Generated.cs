/* Generated by MyraPad at 11.01.2019 0:16:27 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace MyraPad.UI
{
	partial class ExportOptionsWidget
	{
		private void BuildUI()
		{
			var textBlock1 = new TextBlock();
			textBlock1.Text = "Class Name:";
			textBlock1.Id = "";
			textBlock1.GridRow = 1;

			_textClassName = new TextField();
			_textClassName.Text = "";
			_textClassName.Id = "_textClassName";
			_textClassName.GridColumn = 1;
			_textClassName.GridRow = 1;

			var textBlock2 = new TextBlock();
			textBlock2.Text = "Output Path:";
			textBlock2.GridRow = 2;

			_textOutputPath = new TextField();
			_textOutputPath.Text = "";
			_textOutputPath.Id = "_textOutputPath";
			_textOutputPath.GridColumn = 1;
			_textOutputPath.GridRow = 2;

			_buttonChangeOutputPath = new TextButton();
			_buttonChangeOutputPath.Text = "Change...";
			_buttonChangeOutputPath.Id = "_buttonChangeOutputPath";
			_buttonChangeOutputPath.GridColumn = 2;
			_buttonChangeOutputPath.GridRow = 2;

			var textBlock3 = new TextBlock();
			textBlock3.Text = "Namespace:";

			_textNamespace = new TextField();
			_textNamespace.Text = "";
			_textNamespace.Id = "_textNamespace";
			_textNamespace.GridColumn = 1;

			
			ColumnSpacing = 8;
			RowSpacing = 8;
			ColumnsProportions.Add(new Grid.Proportion());
			ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			ColumnsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			Id = "Root";
			Width = 800;
			Widgets.Add(textBlock1);
			Widgets.Add(_textClassName);
			Widgets.Add(textBlock2);
			Widgets.Add(_textOutputPath);
			Widgets.Add(_buttonChangeOutputPath);
			Widgets.Add(textBlock3);
			Widgets.Add(_textNamespace);
		}

		
		public TextField _textClassName;
		public TextField _textOutputPath;
		public TextButton _buttonChangeOutputPath;
		public TextField _textNamespace;
	}
}