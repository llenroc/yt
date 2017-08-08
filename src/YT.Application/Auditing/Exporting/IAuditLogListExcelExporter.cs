using System.Collections.Generic;
using YT.Auditing.Dto;
using YT.Dto;

namespace YT.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
