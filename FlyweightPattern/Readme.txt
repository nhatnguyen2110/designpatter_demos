Flyweight Pattern là một trong những Pattern thuộc nhóm cấu trúc (Structural Pattern). 
Nó cho phép tái sử dụng đối tượng tương tự đã tồn tại bằng cách lưu trữ chúng hoặc tạo đối tượng mới khi không tìm thấy đối tượng phù hợp.

Các thành phần trong mẫu thiết kế Flyweight:

Flyweight : là một interface/ abstract class, định nghĩa các các thành phần của một đối tượng.
ConcreteFlyweight : triển khai các phương thức đã được định nghĩa trong Flyweight. Việc triển khai này phải thực hiện các khả năng của trạng thái nội tại. 
Đó là dữ liệu phải không thể thay đổi (unchangeable) và có thể chia sẻ (shareable). Các đối tượng là phi trạng thái (stateless) trong triển khai này. 
Vì vậy, đối tượng ConcreteFlyweight giống nhau có thể được sử dụng trong các ngữ cảnh khác nhau.
UnsharedFlyweight : mặc dù mẫu thiết kế Flyweight cho phép chia sẻ thông tin, nhưng có thể tạo ra các thể hiện không được chia sẻ (not shared). 
Trong những trường hợp này, thông tin của các đối tượng có thể là stateful.
FlyweightFactory (Cache): lớp này có thể là một Factory Pattern được sử dụng để giữ tham chiếu đến đối tượng Flyweight đã được tạo ra. 
Nó cung cấp một phương thức để truy cập đối tượng Flyweight được chia sẽ. 
FlyweightFactory bao gồm một Pool (không cho phép bên ngoài truy cập vào) để lưu trữ đối tượng Flyweight trong bộ nhớ. 
Nó sẽ trả về đối tượng Flyweight đã tồn tại khi được yêu cầu từ Client hoặc tạo mới nếu không tồn tại.
Client : sử dụng FlyweightFactory để khởi tạo đối tượng Flyweight.