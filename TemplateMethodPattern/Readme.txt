 Template method giúp cho chúng ta tạo nên một bộ khung (template) cho một vấn đề đang cần giải quyết. 
 Trong đó các đối tượng cụ thể sẽ có cùng các bước thực hiện, nhưng trong mỗi bước thực hiện đó có thể khác nhau. 
 Điều này sẽ tạo nên một cách thức truy cập giống nhau nhưng có hành động và kết quả khác nhau.

 Các thành phần tham gia Template Method Pattern:

AbstractClass :
Định nghĩa các phương thức trừu tượng cho từng bước có thể được điều chỉnh bởi các lớp con.
Cài đặt một phương thức duy nhất điều khiển thuật toán và gọi các bước riêng lẻ đã được cài đặt ở các lớp con.
ConcreteClass : là một thuật toán cụ thể, cài đặt các phương thức của AbstractClass. 
Các thuật toán này ghi đè lên các phương thức trừu tượng để cung cấp các triển khai thực sự. 
Nó không thể ghi đè phương thức duy nhất đã được cài đặt ở AbstractClass (templateMethod).