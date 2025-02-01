using SCPSL_Framework.Managers;
using SCPSL_Framework.Items.Weapons;
using SCPSL_Framework.GameRoles.Humans;
using SCPSL_Framework.GameRoles.SCPs;
using SCPSL_Framework.Scripts.Events.SpecificEvents;
using System;
using System.Collections.Generic;
using PluginFramework;
using SCPSL_Framework.GameRoles;
using SCPSL_Framework.Scripts.Core;
using SCPSL_Framework.Scripts.Events;
using SCPSL_Framework.Scripts.Events.SpecificEvents;
using static SCPSL_Framework.Scripts.Core.LoaderMessages;
using static SCPSL_Framework.Scripts.Core.LoaderMessages;
using EventManager = SCPSL_Framework.Scripts.Events.EventManager;

class ExampleUsage
{
    static void Main()
    {
        // Load configurations and display version information
        LoaderMessages.Loader.ToString()   ;

        // Display loader message according to the actual month
        LoaderMessages.Ramadan.ToString() ;

        // إنشاء مدير العناصر
        ItemManager itemManager = new ItemManager();

        // إضافة الأسلحة إلى مدير العناصر
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

        // عرض جميع العناصر
        itemManager.ListItems();

        // إنشاء الأدوار البشرية
        Guard guard = new Guard();
        MTF mtf = new MTF();
        ClassD classD = new ClassD();
        Scientist scientist = new Scientist();

        // عرض معلومات الأدوار البشرية
        DisplayRoleInfo(guard);
        DisplayRoleInfo(mtf);
        DisplayRoleInfo(classD);
        DisplayRoleInfo(scientist);

        // إنشاء أدوار SCP
        SCP173 scp173 = new SCP173();
        SCP049 scp049 = new SCP049();
        SCP106 scp106 = new SCP106();
        SCP079 scp079 = new SCP079();
        SCP096 scp096 = new SCP096();
        SCP999 scp999 = new SCP999();

        // عرض معلومات أدوار SCP
        DisplayRoleInfo(scp173);
        DisplayRoleInfo(scp049);
        DisplayRoleInfo(scp106);
        DisplayRoleInfo(scp079);
        DisplayRoleInfo(scp096);
        DisplayRoleInfo(scp999);

        // إنشاء مدير الأحداث
        EventManager eventManager = new EventManager();

        // تسجيل الأحداث
        PlayerJoinedEvent playerJoinedEvent = new PlayerJoinedEvent("Player1");
        eventManager.RegisterEvent(playerJoinedEvent);

        PlayerJoinedEvent playerLeftEvent = new PlayerJoinedEvent("Player1");
        eventManager.RegisterEvent(playerLeftEvent);

        // تفعيل الأحداث
        eventManager.TriggerEvent("PlayerJoined");
        eventManager.TriggerEvent("PlayerLeft");
    }

    static void DisplayRoleInfo(HumanRole humanRole)
    {
        Console.WriteLine($"Role: {humanRole.RoleName}, Health: {humanRole.Health}, Armor: {humanRole.Armor}, Weapons: {string.Join(", ", humanRole.Weapons)}");
    }

    static void DisplayRoleInfo(SCPRole scpRole)
    {
        Console.WriteLine($"SCP Number: {scpRole.SCPNumber}, Health: {scpRole.Health}, Abilities: {string.Join(", ", scpRole.Abilities)}");
    }
}