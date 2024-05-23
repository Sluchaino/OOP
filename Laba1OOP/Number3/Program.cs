using Number3;

Node nodes = new(1);
Node nodes1 = new(2);
Node nodes2 = new(3);
Node nodes3 = new(4);

nodes.childrens.Add(nodes1);
nodes.childrens.Add(nodes2);
nodes.childrens.Add(nodes3);

nodes1.childrens.Add(new(22));
nodes1.childrens.Add(new(23));

nodes2.childrens.Add(new(32));
nodes2.childrens.Add(new(33));

nodes3.childrens.Add(new(42));
nodes3.childrens.Add(new(43));

nodes.PrintValues();