using SCPSL_Framework.Managers;
using SCPSL_Framework.Items.Weapons;
using System.Collections.Generic;

partial class Program
{
    static void Main()
    {
        ItemManager itemManager = new ItemManager();

        // Adding weapons
        A7 a7 = new A7();
        itemManager.AddItem(a7);

        AK ak = new AK();
        itemManager.AddItem(ak);

        COM15 com15 = new COM15();
        itemManager.AddItem(com15);

        COM18 com18 = new COM18();
        itemManager.AddItem(com18);

        COM45 com45 = new COM45();
        itemManager.AddItem(com45);

        Crossvec crossvec = new Crossvec();
        itemManager.AddItem(crossvec);

        FRMG0 frmg0 = new FRMG0();
        itemManager.AddItem(frmg0);

        FSP9 fsp9 = new FSP9();
        itemManager.AddItem(fsp9);

        itemManager.ListItems();
    }
}