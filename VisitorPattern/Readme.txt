Visitor Pattern là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). 
Visitor cho phép định nghĩa các thao tác (operations) trên một tập hợp các đối tượng (objects) không đồng nhất (về kiểu) 
mà không làm thay đổi định nghĩa về lớp (classes) của các đối tượng đó. 
Để đạt được điều này, trong mẫu thiết kế visitor ta định nghĩa các thao tác trên các lớp tách biệt gọi các lớp visitors, 
các lớp này cho phép tách rời các thao tác với các đối tượng mà nó tác động đến. Với mỗi thao tác được thêm vào, một lớp visitor tương ứng được tạo ra.

Các thành phần tham gia Visitor Pattern:

Visitor :
Là một interface hoặc một abstract class được sử dụng để khai báo các hành vi cho tất cả các loại visitor.
Class này định nghĩa một loạt các các phương thức truy cập chấp nhận các ConcreteElement cụ thể khác nhau làm tham số. 
Điều này sẽ hơi giống với cơ chế nạp chồng (overloading) nhưng các loại tham số nên khác nhau do đó các hành vi hoàn toàn khác nhau. 
Các hành vi truy cập sẽ được thực hiện trên từng phần tử cụ thể trong cấu trúc đối tượng thông qua phương thức visit(). 
Loại phần tử cụ thể đầu vào sẽ quyết định phương thức được gọi.
ConcreteVisitor : cài đặt tất cả các phương thức abstract đã khai báo trong Visitor. Mỗi visitor sẽ chịu trách nhiệm cho các hành vi khác nhau của đối tượng.
Element (Visitable): là một thành phần trừu tượng, nó khai báo phương thức accept() và chấp nhận đối số là Visitor.
ConcreteElement (ConcreteVisitable): cài đặt phương thức đã được khai báo trong Element dựa vào đối số visitor được cung cấp.
ObjectStructure : là một lớp chứa tất cả các đối tượng Element, cung cấp một cơ chế để duyệt qua tất cả các phần tử. 
Cấu trúc đối tượng này có thể là một tập hợp (collection) hoặc một cấu trúc phức tạp giống như một đối tượng tổng hợp (composite).
Client : không biết về ConcreteElement và chỉ gọi phương thức accept() của Element.

