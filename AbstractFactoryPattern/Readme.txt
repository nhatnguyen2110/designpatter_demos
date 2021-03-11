Abstract Factory pattern là phương pháp tạo ra một Super-factory dùng để tạo ra các Factory khác. 
Hay còn được gọi là Factory của các Factory. Abstract Factory Pattern là một Pattern cấp cao hơn so với Factory Method Pattern.

Một Abstract Factory Pattern bao gồm các thành phần cơ bản sau:

AbstractFactory: Khai báo dạng interface hoặc abstract class chứa các phương thức để tạo ra các đối tượng abstract.
ConcreteFactory: Xây dựng, cài đặt các phương thức tạo các đối tượng cụ thể.
AbstractProduct: Khai báo dạng interface hoặc abstract class để định nghĩa đối tượng abstract.
Product: Cài đặt của các đối tượng cụ thể, cài đặt các phương thức được quy định tại AbstractProduct.
Client: là đối tượng sử dụng AbstractFactory và các AbstractProduct.