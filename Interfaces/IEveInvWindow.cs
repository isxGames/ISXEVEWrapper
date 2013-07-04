using System;
using System.Collections.Generic;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    /// <summary>
    /// Wrapper for the EveInvWindow datatype.
    /// </summary>
    public interface IEveInvWindow : ILSObject
    {
        /// <summary>
        /// Get the active child window.
        /// </summary>
        IEveInvChildWindow ActiveChild { get; }

        /// <summary>
        /// Wrapper for the Caption member of the evewindow type.
        /// </summary>
        string Caption { get; }

        /// <summary>
        /// Wrapper for the Minimized member of the evewindow type.
        /// </summary>
        bool Minimized { get; }

        /// <summary>
        /// Wrapper for the HTML member of the evewindow type.
        /// </summary>
        string HTML { get; }

        string Text { get; }

        /// <summary>
        /// The ID of the ship or other object that this window belongs to, i.e. EVEWindow[MyShipCargo].ItemID will be your ship ID
        /// </summary>
        Int64 ItemID { get; }

        /// <summary>
        /// The capacity of the container represented by this EVEWindow.
        /// </summary>
        double Capacity { get; }

        /// <summary>
        /// The used capacity of the container represented by this EVEWindow.
        /// </summary>
        double UsedCapacity { get; }

        /// <summary>
        /// Get a child window by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEveInvChildWindow GetChildWindow(long id);

        /// <summary>
        /// Get a child window by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IEveInvChildWindow GetChildWindow(string name);

        /// <summary>
        /// Get a child window by name and location.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        IEveInvChildWindow GetChildWindow(string name, string location);

        /// <summary>
        /// Get a child window by ID and Name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        IEveInvChildWindow GetChildWindow(long id, string name);

        /// <summary>
        /// Get a child window by ID, Name, and Location.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        IEveInvChildWindow GetChildWindow(long id, string name, string location);

        /// <summary>
        ///  Get the child windows of this EveInvWindow
        /// </summary>
        /// <returns></returns>
        List<IEveInvChildWindow> GetChildren();

        /// <summary>
        /// Wrapper for the Close method of the evewindow type.
        /// </summary>
        /// <returns></returns>
        bool Close();

        /// <summary>
        /// Wrapper for the Maximize method of the evewindow type.
        /// </summary>
        /// <returns></returns>
        bool Maximize();

        /// <summary>
        /// Wrapper for the Minimize method of the evewindow type.
        /// </summary>
        /// <returns></returns>
        bool Minimize();

        bool ClickButtonYes();
        bool ClickButtonNo();
        bool ClickButtonOK();
        bool ClickButtonCancel();
        bool ClickButtonClose();
        bool StackAll();
    }
}