using PropotypeFormas.Instanciables;

Circle circulito = new Circle { Id = 1};
Square cuadradin = new Square { Id = 2 };
Triangle trianguleque = new Triangle { Id = 3 };

//Draw original shapes
circulito.Draw();
cuadradin.Draw();
trianguleque.Draw();

//testing clone method
//                              circulito.Clone(); da error, debe ser casteado al tipo de objeto.
Circle clonCirculito = (Circle)circulito.Clone();
Square clonCuadradin =  (Square)cuadradin.Clone();
Triangle clonTrianguleque =  (Triangle)trianguleque.Clone();

//testing clones
clonCirculito.Draw();
clonCuadradin.Draw();
clonTrianguleque.Draw();

//other test
clonCirculito.Id = 56;
clonCirculito.Draw();
circulito.Draw();