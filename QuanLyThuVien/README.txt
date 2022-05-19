Form:
	Form danh sách
		- Tự chủ dữ liệu
		- Có khả năng thay đổi dữ liệu trong csdl
	Form chi tiết:
		- Phụ thuộc dữ liệu vào Form cha
		- Có khả năng thay đổi dữ liệu trong csdl
		- Đầu vào là một đối tượng cụ thể
	Form danh sách phụ:
		- Phụ thuộc dữ liệu vào Form cha
		- Không có khả năng thay đổi dữ liệu trong csdl
	Form chi tiết phụ:
		- Phụ thuộc dữ liệu vào Form cha
		- Không có khả năng thay đổi dữ liệu trong csdl

Archive:
	- CurrentLibrarian: Thủ thư đang đăng nhập
	- Đảm nhận giao tiếp dữ liệu giữa các form khác nhau

Try vấn:
	- Các câu try vấn lấy dữ liệu được viết trực tiếp
	- Các câu try vấn thêm hoặc cập nhật dữ liệu được viết bằng Store Procedure
	- Các câu try vấn xóa có thể được viết trực tiếp, hoặc viết bằng Store Procedure

Tên bảng và tên trường:
	- Được viết dạng Pascal (Ví dụ: Librarian, BookTitle)

Tên Store Procedure:
	- Dạng `sp_<Hành động>_[<Đối tượng>]_[Phân biệt]`
	- Ví dụ: sp_login, sp_create_librarian, sp_create_librarian_include_account

Store Procedure thêm, sửa:
	- Các tham số truyền vào của sp thêm và cập nhật nhật là như nhau trên cùng một lớp đối tượng.
	- Các tham số được viết theo nguyên tắc chuyển tên trường tương ứng sang dạng chuỗi gạch dưới (Ví dụ: FirstName -> first_name)

DataObject:
	- Các thuộc tính được gán nhãn `Column` buộc phải xuất hiện trong dữ liệu được trả về từ truy vấn
	- Các thuộc tính được gán nhãn `Required` buộc phải có anh xạ là tham số tương ứng xuất hiện trong sp thêm và sửa