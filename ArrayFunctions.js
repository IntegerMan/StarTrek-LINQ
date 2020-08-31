
const activeItems = myArray.filter(i => i.isActive);
// Equivalent to LINQ's Where


const firstMatch = myArray.find(i => i.numSpaceWhales > 0);
// Equivalent to LINQ's FirstOrDefault


const titles = myArray.map(i => i.title);
// Equivalent to LINQ's Select