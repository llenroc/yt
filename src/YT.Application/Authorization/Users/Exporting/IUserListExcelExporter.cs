using System.Collections.Generic;
using YT.Authorization.Users.Dto;
using YT.Dto;

namespace YT.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}