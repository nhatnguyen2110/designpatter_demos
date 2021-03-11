Object Pool Pattern cung cấp một kỹ thuật để tái sử dụng objects thay vì khởi tạo không kiểm soát.

Một Object Pool Pattern bao gồm các thành phần cơ bản sau:

Client : một class yêu cầu khởi tạo đối tượng PooledObject để sử dụng.
PooledObject : một class mà tốn nhiều thời gian và chi phí để khởi tạo. Một class cần giới hạn số lượng đối tượng được khởi tạo trong ứng dụng.
ObjectPool : đây là lớp quan trọng nhất trong Object Pool Pattern. Lớp này lưu giữ danh sách các PooledObject đã được khởi tạo, đang được sử dụng. 
Nó cung cấp các phương thức cho việc lấy đối tượng từ Pool và trả đối tượng sau khi sử dụng về Pool.