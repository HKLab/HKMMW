﻿namespace HKMMW.Core.Contracts.ModData;

public interface IModInfo
{
    string Name
    {
        get;
    }
    string Description
    {
        get;
    }
    Version Version
    {
        get;
    }
    string DisplayName => Name;
    string ModId
    {
        get;
    }
    IList<string> Dependencies
    {
        get;
    }
    IList<string> Integrations
    {
        get;
    }

    bool IsLocal => this is IModInfoLocal;
    bool IsDownloadable => this is IModInfoDownloadable downloadable && downloadable.ModSize > 0;
    bool IsVerifiable => this is IModInfoVerifiable;
}
