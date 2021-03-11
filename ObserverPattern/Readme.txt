Observer Pattern là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). 
Nó định nghĩa mối phụ thuộc một – nhiều giữa các đối tượng để khi mà một đối tượng có sự thay đổi trạng thái, 
tất các thành phần phụ thuộc của nó sẽ được thông báo và cập nhật một cách tự động.

Các thành phần tham gia Observer Pattern:

Subject : chứa danh sách các observer,  cung cấp phương thức để có thể thêm và loại bỏ observer.
Observer : định nghĩa một phương thức update() cho các đối tượng sẽ được subject thông báo đến khi có sự thay đổi trạng thái.
ConcreteSubject : cài đặt các phương thức của Subject, lưu trữ trạng thái danh sách các ConcreateObserver, gửi thông báo đến các observer của nó khi có sự thay đổi trạng thái.
ConcreteObserver : cài đặt các phương thức của Observer, lưu trữ trạng thái của subject, thực thi việc cập nhật để giữ cho trạng thái đồng nhất với subject gửi thông báo đến.