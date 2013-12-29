using System;
using System.ComponentModel;
using System.Windows.Forms;
using MiniObfuscator.Core;
using MiniObfuscator.Core.Enums;

namespace MiniObfuscator.WinUI
{
  public partial class OptionsForm : Form
  {
    public ObfuscateOptions Options { get; private set; }

    public OptionsForm()
    {
      InitializeComponent();
    }

    #region Controls Events

    private void OptionsForm_Load(object sender, EventArgs e)
    {
      BindOptions();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SetOptions();
      Close();
    }

    #region SelectedIndexChanged

    private void clbMembers_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(Members), clbMembers);
    }

    private void clbAnonymizeOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(Anonymizers), clbAnonymizeOptions);
    }

    private void clbResourceProtectionMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(ResourceProtection), clbResourceProtectionMode);
    }

    private void lbNaming_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(Naming), lbNaming);
    }

    private void lbAntiILDASMOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(AntiIldasm), lbAntiILDASMOptions);
    }

    private void lbNamespacesRestructuring_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(NamespacesRestructuring), lbNamespacesRestructuring);
    }

    private void lbStringEncryptionMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      GetDescription(typeof(StringEncryption), lbStringEncryptionMode);
    }

    #endregion

    #endregion

    #region SetOptions

    private void SetOptions()
    {
      Options = new ObfuscateOptions();
      Options.Members = GetEnumFromCheckedList<Members>(clbMembers, Members.None.ToString());
      Options.Anonymizer = GetEnumFromCheckedList<Anonymizers>(clbAnonymizeOptions, Members.None.ToString());
      Options.ResourcesProtection = GetEnumFromCheckedList<ResourceProtection>(clbResourceProtectionMode, ResourceProtection.None.ToString());

      Options.Naming = GetEnumFromList<Naming>(lbNaming);
      Options.AntiIldasm = GetEnumFromList<AntiIldasm>(lbAntiILDASMOptions);
      Options.NamespacesRestructuring = GetEnumFromList<NamespacesRestructuring>(lbNamespacesRestructuring);
      Options.StringEncryptionMode = GetEnumFromList<StringEncryption>(lbStringEncryptionMode);

      Options.CustomDictionary = txtCustomDictionary.Text;
      Options.SoftwareWatermark = txtSoftwareWatermark.Text;

      Options.IncrementalObfuscation = cbIncrementalObfuscation.Checked;
      Options.MixDictionary = cbMixDictionary.Checked;
      Options.UniqueNames = cbUniqueNames.Checked;
    }

    private T GetEnumFromCheckedList<T>(CheckedListBox list, string defaultValue) where T : struct
    {
      var enumType = typeof(T);
      dynamic value = (T)Enum.Parse(enumType, defaultValue);
      foreach (string item in list.CheckedItems)
      {
        value = value | (T)Enum.Parse(enumType, item);
      }
      return (T)value;
    }

    private T GetEnumFromList<T>(ListBox list) where T : struct
    {
      if (list.SelectedItem == null) return default(T);
      var enumType = typeof(T);
      return (T)Enum.Parse(enumType, list.SelectedItem.ToString());
    }

    #endregion

    #region Private Methods

    private void BindOptions()
    {
      BindEnumToListBox(typeof(Members), clbMembers);
      BindEnumToListBox(typeof(Naming), lbNaming);
      BindEnumToListBox(typeof(NamespacesRestructuring), lbNamespacesRestructuring);

      BindEnumToListBox(typeof(Anonymizers), clbAnonymizeOptions);
      BindEnumToListBox(typeof(AntiIldasm), lbAntiILDASMOptions);
      BindEnumToListBox(typeof(ResourceProtection), clbResourceProtectionMode);
      BindEnumToListBox(typeof(StringEncryption), lbStringEncryptionMode);
    }

    private void BindEnumToListBox(Type enumType, ListBox lb)
    {
      lb.Items.Clear();
      lb.Items.AddRange(Enum.GetNames(enumType));
    }

    private void GetDescription(Type enumType, ListBox lb)
    {
      var m = (Enum)Enum.Parse(enumType, lb.SelectedItem.ToString());
      txtDescription.Text = GetEnumDescription(m);
    }
    public string GetEnumDescription(Enum value)
    {
      var fi = value.GetType().GetField(value.ToString());
      var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
      return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
    }

    #endregion
  }
}
