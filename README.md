# Logitech CVE

**Purpose**
> Uses a vulnerability within the Logitech GHUB virtual mouse driver to input mouse functions (aka, mouse movement and clicks).


**Usage**
> An older installation of Logitech GHUB must be installed due to Logitech removing the virtual mouse driver in the latest version(s) of GHUB.

```ruby
public static void Move(int button, int x, int y, int wheel) {
    Struct.MOUSE_IO io;
    io.Unk1 = 0;
    io.Button = (byte)button;
    io.X = (byte)x;
    io.Y = (byte)y;
    io.Wheel = (byte)wheel;

    if (!Call(io)) {
        Close();
        Open();
    }
}
```

Credit to [ekknod](https://github.com/ekknod).
