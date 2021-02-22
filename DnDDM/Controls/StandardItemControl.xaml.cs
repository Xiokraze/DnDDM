using DnDDM.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static DnDDM.Classes.DefaultValues;

namespace DnDDM.Controls
{
    /// <summary>
    /// Interaction logic for StandardItemControl.xaml
    /// </summary>
    public partial class StandardItemControl : UserControl
    {
        private readonly StandardItemLists itemLists = new StandardItemLists();
        public StandardItemControl(string control)
        {
            InitializeComponent();
            UpdateGUI(control);
        }


        private void UpdateGUI(string control)
        {
            if (control.Equals(DefaultValues.Armor))
            {
                UpdateArmorTable();
            }
            else if (control.Equals(DefaultValues.Art))
            {
                //UpdateArtTable();
            }
            else if (control.Equals(DefaultValues.Gem))
            {
                //UpdateGemTable();
            }
            else if (control.Equals(DefaultValues.Good))
            {
                //UpdateGoodTable();
            }
            else if (control.Equals(DefaultValues.Weapon))
            {
                //UpdateWeaponTable();
            }
            else if (control.Equals(DefaultValues.Trinket))
            {
                //UpdateTrinketTable();
            }
        }


        private void AddDataGridColumn(string columnHeader, string bindingValue, TextAlignment alignment)
        {
            // DataGrid header style.
            Style headerStyle = new Style(typeof(DataGridColumnHeader));
            headerStyle.Setters.Add(new Setter { Property = HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Center });
            headerStyle.Setters.Add(new Setter { Property = BackgroundProperty, Value = DnDBlackBrush });
            headerStyle.Setters.Add(new Setter { Property = ForegroundProperty, Value = DnDLightBrush });
            headerStyle.Setters.Add(new Setter { Property = BorderBrushProperty, Value = DnDLightBrush });
            headerStyle.Setters.Add(new Setter { Property = BorderThicknessProperty, Value = new Thickness(1) });
            headerStyle.Setters.Add(new Setter { Property = PaddingProperty, Value = new Thickness(4) });
            headerStyle.Setters.Add(new Setter { Property = FontSizeProperty, Value = 14.0 });

            // DataGrid cell style.
            Style cellStyle = new Style();
            cellStyle.Setters.Add(new Setter(TextBlock.TextAlignmentProperty, alignment));
            cellStyle.Setters.Add(new Setter { Property = BackgroundProperty, Value = DefaultValues.DnDBlackBrush });
            cellStyle.Setters.Add(new Setter { Property = BorderThicknessProperty, Value = new Thickness(0) });
            cellStyle.Setters.Add(new Setter { Property = FontSizeProperty, Value = 12.0 });

            // Create column.
            DataGridTextColumn dataColumn = new DataGridTextColumn
            {
                Header = columnHeader,
                Binding = new Binding(bindingValue),
                CellStyle = cellStyle,
                HeaderStyle = headerStyle
            };
            dataGridView.Columns.Add(dataColumn);
        }


        private void UpdateArmorTable()
        {
            AddDataGridColumn("Description", "Description", TextAlignment.Left);
            AddDataGridColumn("Classification", "Classification", TextAlignment.Center);
            AddDataGridColumn("Value", "Value", TextAlignment.Right);
            AddDataGridColumn("AC", "ArmorClass", TextAlignment.Center);
            AddDataGridColumn("Strength", "RequiredStrength", TextAlignment.Center);
            AddDataGridColumn("Stealth", "StealthImpact", TextAlignment.Center);
            AddDataGridColumn("Weight", "Weight", TextAlignment.Right);
            dataGridView.ItemsSource = itemLists.armor;
        }
    }
}
