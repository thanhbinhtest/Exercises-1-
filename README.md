
# Web Service and Client Application

## Web Service (WebService1)
Web Service được xây dựng bằng ASP.NET Web Services và kết nối với cơ sở dữ liệu SQL Server. Web Service này cung cấp các phương thức để tương tác với dữ liệu quốc gia và thành phố lưu trong cơ sở dữ liệu.
### Các tính năng đã triển khai
1. Kết nối cơ sở dữ liệu:
- Web Service kết nối với cơ sở dữ liệu BTVN thông qua chuỗi kết nối (connection string =  "Data Source=DESKTOP-OHV1CLJ\\MSSQLSERVER01;Initial Catalog=BTVN;Integrated Security=True;Encrypt=False")

- Các truy vấn được thực thi bằng SqlConnection và SqlCommand.
2. Các phương thức hỗ trợ:
- ExecuteQuery: Thực thi câu lệnh SQL và trả về kết quả dưới dạng danh sách các từ điển (dictionary).
- ConvertToCountries và ConvertToCities: Chuyển đổi kết quả thô từ truy vấn thành danh sách các đối tượng kiểu mạnh (Country và City).
3. Mô hình dữ liệu:
- Country (Quốc gia): Thuộc tính: Code, Name, Continent, Region, Population.
- City (Thành phố): Thuộc tính: ID, Name, CountryCode, District, Population.
4. Các phương thức Web (Web Methods):
- GetAllCountries: Lấy tất cả thông tin quốc gia từ cơ sở dữ liệu.
- GetCountryByCode: Lấy thông tin quốc gia dựa trên mã quốc gia.
- GetCityByName: Lấy thông tin thành phố theo tên.
- GetAllCitiesByCountryCode: Lấy danh sách tất cả thành phố của một quốc gia dựa trên mã quốc gia.
- GetCitiesByDistrict: Lấy danh sách các thành phố dựa trên quận/huyện (sử dụng câu truy vấn LIKE).
### Tương tác cơ sở dữ liệu
- Sử dụng truy vấn có tham số để ngăn chặn SQL injection, đảm bảo an toàn dữ liệu.

## Ứng dụng Client (Form1)
Ứng dụng client được xây dựng bằng Windows Forms và giao tiếp với Web Service để lấy và hiển thị dữ liệu.
### Các tính năng đã triển khai
1. Tham chiếu dịch vụ (Service Reference):

- Ứng dụng sử dụng tham chiếu SOAP của WebService1 để giao tiếp.
2. Thành phần giao diện:

- TextBox: Cho phép người dùng nhập liệu (mã quốc gia, tên thành phố, quận/huyện).
- DataGridView (dgvResults): Hiển thị dữ liệu nhận được.
- Buttons: Kích hoạt các thao tác như lấy danh sách quốc gia, thành phố, v.v.
3. Xử lý sự kiện Button:

- getCountryByCode_Click:
   - Lấy thông tin quốc gia theo mã.
   - Hiển thị kết quả trong dgvResults.
- getCityByName_Click:
   - Lấy thông tin thành phố theo tên.
   - Hiển thị kết quả trong dgvResults.
- getAllCityFromCountryCode_Click:
   - Lấy danh sách tất cả thành phố của một quốc gia.
   - Hiển thị kết quả trong dgvResults.
- getCityByDistrict_Click:
   - Lấy danh sách thành phố theo quận/huyện.
   - Hiển thị kết quả trong dgvResults.
- getAllCountry_Click:
   - Lấy danh sách tất cả quốc gia.
   - Hiển thị kết quả trong dgvResults.
4. Chuyển đổi dữ liệu:

- ConvertToDataTable:
   - Chuyển đổi mảng các đối tượng (như Country[], City[]) thành DataTable để liên kết với dgvResults.
5. Các kỹ thuật được dùng thêm:

- Sử dụng **MessageBox** để hiển thị thông báo thân thiện với người dùng khi gặp lỗi nhập liệu hoặc lỗi dịch vụ.
- Sử dụng giao tiếp bất đồng bộ (async) với Web Service, giúp ứng dụng không bị treo.

## Bảng tính năng

| Tính năng                              | Phương thức Web Service                | Xử lý sự kiện nút trên Client          |
|----------------------------------------|----------------------------------------|----------------------------------------|
| Lấy danh sách quốc gia                 | `GetAllCountries`                      | `getAllCountry_Click`                  |
| Lấy thông tin quốc gia theo mã         | `GetCountryByCode`                     | `getCountrybyCode_Click`               |
| Lấy thông tin thành phố theo tên       | `GetCityByName`                        | `getCityByName_Click`                  |
| Lấy danh sách thành phố theo mã quốc gia | `GetAllCitiesByCountryCode`            | `getAllCityFromCountryCode_Click`     |
| Lấy danh sách thành phố theo quận/huyện | `GetCitiesByDistrict`                  | `getCityByDistrict_Click`             |





