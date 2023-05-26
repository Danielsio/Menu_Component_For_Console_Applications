﻿using System;

namespace Ex04.Menus.Delegates
{
    public class ActionMenuItem : MenuItemBase
    {
        public event Action OnMenuItemChosen;

        public ActionMenuItem(string i_MenuTitle)
            : base(i_MenuTitle)
        {
        }

        public override void SelectMenu()
        {
            if (OnMenuItemChosen != null)
            {
                OnMenuItemChosen.Invoke();
            }
            else
            {
                Console.WriteLine("No action was added to this menu option.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            PrevMenu.SelectMenu();
        }
    }
}