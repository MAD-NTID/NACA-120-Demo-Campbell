// Node<int> root;

// root = new Node<int>(10);
// root.Next= new Node<int>(20, new Node<int>(100));

// Console.WriteLine(root);

Stack<int> stack = new Stack<int>();

for(int i = 1; i <= 10; i++) {
    stack.Push(i);
}

for(int i = 1; i <= 10; i++) {
    Console.WriteLine($"stack contains {i}? {stack.Contains(i)}");
}

Console.WriteLine("Printing the stack elements from top to bottom");
Console.WriteLine(stack);

Console.WriteLine("The top element is :" + stack.Peek());
Console.WriteLine("Popping off the top element: " + stack.Pop());

//testing the IEnumerator
Console.WriteLine("Showing the remaining elements using foreach");
foreach(int element in stack)
{
    Console.WriteLine(element);
}

//to array
int[] elements = stack.ToArray();
Console.WriteLine("Get stack as array elements");
for(int i = 0; i < elements.Length; i++) {
    Console.WriteLine($"index:{i}, element:{elements[i]}");
}

stack.Clear();
Console.WriteLine("Elements cleared");
Console.WriteLine("The size of the elements after clearing the stack: " + stack.Count);
Console.WriteLine("The contents:"+ stack.ToString());



// //this will represent the second element with a link to null as there are no more elements after that
// Node<int> element2 = new Node<int>(15, null);

// //this will first node with a link to the second element
// Node<int> element1 = new Node<int>(10);
// element1.Next = element2;

// //call the toString to show all connecting nodes
// Console.WriteLine(element1);

