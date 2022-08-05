# 04_Polymorphism_Method-Overload
### Polymorphism mean 1 name many implementations
Method overloading is the ability to redefined a function more than one form

Method sharing the same name, but different parameters.
```
public string Me(){             # No parameter
  return "Hello"; 
}
public string Me(int num){      # 1 int parameter
  return "Hello" + num;
}
public string Me(string name){  # 1 string parameter
  return "Hello" + name;
}

```

### Method overloading can be done by changing
- The number of parameters in two methods.
- The data types of the parameters of methods.
- The Order of the parameters of methods.
