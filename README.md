# WorkManagement.Shared

Thư viện hằng số và khóa cấu hình dùng chung cho **QuanLyCongViec** (`Services`, `HostingOptions`).
Tách từ `server/Shared` (giữ lịch sử commit).

## API

```csharp
using WorkManagement.Shared;

var db = builder.AddConnectionString(Services.Database);
var serveSpa = builder.Configuration.GetValue($"{HostingOptions.SectionName}:{HostingOptions.ServeSpa}", true);
```

## Build cục bộ

```bash
dotnet build WorkManagement.Shared.slnx -c Release
dotnet test WorkManagement.Shared.slnx -c Release --no-build
dotnet pack WorkManagement.Shared.slnx -c Release --no-build -o out
```

## Phát hành & dùng trong server

Workflow [`.github/workflows/nuget.yml`](.github/workflows/nuget.yml): push/PR → build, test, pack (artifact `nuget`);
tag `vX.Y.Z` → GitHub Release kèm `.nupkg`/`.snupkg` **và** đẩy `.nupkg` lên GitHub Packages
(`https://nuget.pkg.github.com/phu-nam-hai-jsco/index.json`, private, xác thực bằng `GITHUB_TOKEN`).

Server dùng feed cục bộ `server/packages/` (xem `server/nuget.config`). Cập nhật server sau khi phát hành:

```bash
gh release download vX.Y.Z --repo phu-nam-hai-jsco/work-management-shared --pattern "*.nupkg" --dir server/packages
```

rồi sửa `<PackageVersion Include="WorkManagement.Shared" Version="X.Y.Z" />` trong `server/Directory.Packages.props`.

