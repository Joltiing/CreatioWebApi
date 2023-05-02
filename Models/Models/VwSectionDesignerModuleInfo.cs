using System;
using System.Collections.Generic;

namespace Models.Models;

public partial class VwSectionDesignerModuleInfo
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string CaptionOld { get; set; } = null!;

    public string? Caption { get; set; }

    public string DefaultCaption { get; set; } = null!;

    public string? Header { get; set; }

    public string HeaderOld { get; set; } = null!;

    public string DefaultHeader { get; set; } = null!;

    public Guid WorkspaceId { get; set; }

    public string WorkspaceName { get; set; } = null!;

    public Guid? EntityId { get; set; }

    public string EntityName { get; set; } = null!;

    public Guid? SectionSchemaId { get; set; }

    public string SectionSchemaName { get; set; } = null!;

    public Guid? EntityTagId { get; set; }

    public string EntityTagName { get; set; } = null!;

    public Guid? EntityInTagId { get; set; }

    public string EntityInTagName { get; set; } = null!;

    public Guid? EntityFolderId { get; set; }

    public string EntityFolderName { get; set; } = null!;

    public Guid? EntityInFolderId { get; set; }

    public string EntityInFolderName { get; set; } = null!;

    public Guid? TypeColumnId { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public Guid SysModuleCaptionLczId { get; set; }

    public Guid SysModuleHeaderLczId { get; set; }

    public Guid? CultureId { get; set; }

    public Guid? Image32Id { get; set; }

    public Guid? LogoId { get; set; }

    public Guid? SectionDetailId { get; set; }

    public string? SectionDetailName { get; set; }
}
