
const activeItems = myArray.filter(i => i.isActive);
// Equivalent to LINQ's Where


const firstMatch = myArray.find(i => i.id === 42);
// Equivalent to LINQ's FirstOrDefault


const titles = myArray.map(i => i.title);
// Equivalent to LINQ's Select