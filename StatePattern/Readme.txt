State Pattern là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). 
Nó cho phép một đối tượng thay đổi hành vi của nó khi trạng thái nội bộ của nó thay đổi. Đối tượng sẽ xuất hiện để thay đổi lớp của nó.

Các thành phần tham gia State Pattern:

Context : được sử dụng bởi Client. Client không truy cập trực tiếp đến State của đối tượng. Lớp Context này chứa thông tin của ConcreteState object, 
cho hành vi nào tương ứng với trạng thái nào hiện đang được thực hiện.
State : là một interface hoặc abstract class xác định các đặc tính cơ bản của tất cả các đối tượng ConcreteState. 
Chúng sẽ được sử dụng bởi đối tượng Context để truy cập chức năng có thể thay đổi.
ConcreteState : cài đặt các phương thức của State. Mỗi ConcreteState có thể thực hiện logic và hành vi của riêng nó tùy thuộc vào Context.