// -----------------------------------------------------------------------------------------------
//  IDemo.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKod_CLO22_Linq_20221115.Interfaces;

public interface IDemo
{
    #region Public Properties

    /// <summary>
    /// Get the name of the class
    /// </summary>
    /// <returns>String with the name of the class</returns>
    string GetClassName => this.GetType().Name;

    #endregion Public Properties

    #region Public Methods

    /// <summary>
    /// Starts the demo
    /// </summary>
    void Start();

    #endregion Public Methods
}