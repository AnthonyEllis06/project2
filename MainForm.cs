using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataStructures
{
    public partial class MainForm : Form
    {
        private NameList Names;
        private AutoCompleteStringCollection AutoNames;
        private int SelectedIndex;
        private List<int> IndexesFound;
        public MainForm(String FilesName)
        {
            InitializeComponent(); 
            Names = new NameList(Tools.FileToString(FilesName));
            AutoNames = new AutoCompleteStringCollection();
            IndexesFound = new List<int>();
            for (int i = 0; i < Names.Count; i++)
            {
                NamesListView.Items.Add(new ListViewItem(Names[i].NameToString()));
                AutoNames.Add(Names[i].ToString());
            }
            setCounter();
        }
        public MainForm()
        {
            InitializeComponent();

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoNames = new AutoCompleteStringCollection();
            AutoNames.AddRange(Names.ToArray());
            NameToRemove.AutoCompleteSource = AutoCompleteSource.CustomSource;
            NameToRemove.AutoCompleteCustomSource = AutoNames;
            NameToRemove.AutoCompleteMode = AutoCompleteMode.Suggest;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            AddName(AddTextBox.Text);
        }

        private void NameToRemove_TextChanged(object sender, EventArgs e)
        {
            if (NamesListView.Items.Contains(new ListViewItem(NameToRemove.Text)))
                RemoveButton.Visible = true;
            else
                RemoveButton.Visible = false;
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            Names[SelectedIndex].Rest = EditRestText.Text;
            Names[SelectedIndex].Last = EditLastText.Text;
            Names[SelectedIndex].Suffix = EditSuffText.Text;
            String EditedOriginal = EditRestText.Text.Trim() +" "+ EditLastText.Text.Trim()+" "+ EditSuffText.Text.Trim();
            Names[SelectedIndex].Original = EditedOriginal.Trim();
            NamesListView.Items[SelectedIndex].Text = Names[SelectedIndex].NameToString();
            Names.ListChange();
        }

        private void setCounter()
        {
            NumNamesLabel.Text = "Name Count: " + Names.Count;
        }

        private void AddTextBox_TextChanged(object sender, EventArgs e)
        {
            Name NameToAdd = new Name(AddTextBox.Text);
            AddPartsFirst.Text = NameToAdd.Rest;
            AddPartsLast.Text = NameToAdd.Last;
            AddPartsSuff.Text = NameToAdd.Suffix;
            if (NameToAdd.Rest != null && NameToAdd.Last != null)
                AddButton.Visible = true;
            else
                AddButton.Visible = false;

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            AddName(AddTextBox.Text);
            setCounter();
        }

        private void AddName(String NameToAdd)
        {
            Name name = new Name(NameToAdd);
                Names.Add(name);
                NamesListView.Items.Add(NameToAdd);
                AutoNames.Add(NameToAdd);
                setCounter();
        }

        private void RemoveName(String NameToRemove)
        {
            Name name = new Name(NameToRemove);
            int indexOfName = Names.IndexOf(name);
            if (indexOfName !=-1)
            {
                NamesListView.Items.RemoveAt(indexOfName);
                AutoNames.Remove(Names[indexOfName].NameToString());
                Names.Remove(NameToRemove);
                setCounter();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveName(NameToRemove.Text);
        }

        private void NamesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (EditTab != NameTabControl.SelectedTab)
            {
                SelectedIndex = e.ItemIndex;
                Name Selected = Names[e.ItemIndex];
                EditRestText.Text = Selected.Rest;
                EditLastText.Text = Selected.Last;
                EditSuffText.Text = Selected.Suffix;
                EditButton.Visible = false;
                EditRestText.Update();
            }
        }
    }
}
