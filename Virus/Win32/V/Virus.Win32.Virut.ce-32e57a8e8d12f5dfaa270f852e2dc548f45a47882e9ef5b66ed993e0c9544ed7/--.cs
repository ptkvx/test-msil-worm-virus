using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;

internal delegate Guid _0011_0002();
internal delegate byte[] _0012_0002(object, byte[], int, int);
internal delegate Assembly[] _0013_0002(object);
internal delegate void _0014_0002(object, EventHandler);
internal delegate void _0015_0002(Array, Array, int);
internal delegate void _0016_0002(object, IntPtr);
internal delegate void _0017_0002(Array, int, Array, int, int);
internal delegate byte[] _0018_0002(object);
internal delegate object _0019_0002(object, Delegate, object[]);
internal delegate string _001A_0002(object, string, string);
internal delegate DateTime _001B_0002();
internal delegate Size _001C_0002(object);
internal delegate string _001D_0002(object, int);
internal delegate PlatformID _001E_0002(object);
internal delegate void _001F_0002(object, int, object);
internal delegate byte[] _007F_0002(object, byte[], bool);
internal delegate ILGenerator _0080_0002(object);
internal delegate void _0081_0002(object, DockStyle);
internal delegate byte[] _0082_0002(object, string);
internal delegate Type _0083_0002(object);
internal delegate bool _0084_0002(string, string);
internal delegate void _0086_0002(object, FormStartPosition);
internal delegate void _0087_0002(object, FlatStyle);
internal delegate void _0088_0002(object, FormBorderStyle);
internal delegate long _0089_0002(object);
internal delegate string _008A_0002(string, string);
internal delegate void _008B_0002(object, PictureBoxSizeMode);
internal delegate FieldInfo _008C_0002(object, string, BindingFlags);
internal delegate void _008D_0002(object, Size);
internal delegate int _008E_0002(object, string);
internal delegate void _008F_0002(object, Rectangle);
internal delegate void _0090_0002(object, Point);
internal delegate int _0091_0002(object, object);
internal delegate void _0092_0002(object, Color);
internal delegate PropertyInfo _0093_0002(object, string);
internal delegate FieldInfo[] _0094_0002(object, BindingFlags);
internal delegate string _0095_0002(object, byte[]);
internal delegate Delegate _0096_0002(Delegate, Delegate);
internal delegate Type _0097_0002(RuntimeTypeHandle);
internal delegate MethodBase _0098_0002(RuntimeMethodHandle);
internal delegate void _0099_0002();
internal delegate string _009A_0002(object, byte[], int, int);
internal delegate void _009B_0002(object, Icon, Rectangle);
internal delegate MethodBase _009C_0002(object);
internal delegate bool _009D_0002(object, string);
internal delegate void _009E_0002(object, ControlStyles, bool);
internal delegate long _009F_0002(object, long, SeekOrigin);
internal delegate int _0001_0003(object, byte[], int, int);
internal delegate void _0002_0003(object, OpCode, int);
internal delegate string _0003_0003(object, string);
internal delegate Cursor _0004_0003();
internal delegate Graphics _0005_0003(object);
internal delegate byte _0006_0003(int);
internal delegate OperatingSystem _0007_0003();
internal delegate StringBuilder _0008_0003(object, string);
internal delegate MethodInfo[] _000E_0003(object, BindingFlags);
internal delegate ICollection _000F_0003(object);
internal delegate void _0010_0003(object, string);
internal delegate IEnumerator _0011_0003(object);
internal delegate void _0012_0003(Array, RuntimeFieldHandle);
internal delegate void _0013_0003(EventHandler);
internal delegate void _0014_0003(object, OpCode, MethodInfo);
internal delegate AppDomain _0015_0003();
internal delegate ProcessModule _0016_0003(object);
internal delegate Module[] _0017_0003(object);
internal delegate bool _0018_0003(object, object, object, object, ref object, ref object);
internal delegate IntPtr _0019_0003(object);
internal delegate string _001A_0003();
internal delegate int _001B_0003(byte[], int);
internal delegate void _001C_0003(object, Image, Rectangle, Rectangle, GraphicsUnit);
internal delegate byte[] _001D_0003(string);
internal delegate void _001E_0003(object, int);
internal delegate string _001F_0003(string);
internal delegate Guid _007F_0003(object);
internal delegate Exception _0080_0003(object);
internal delegate object _0081_0003(object, object);
internal delegate MethodInfo _0082_0003(object);
internal delegate FieldInfo _0083_0003(object, string);
internal delegate void _0084_0003(object, float, float);
internal delegate bool _0086_0003(Guid, Guid);
internal delegate void _0087_0003(object, string, string);
internal delegate void _0088_0003(object, Image, Rectangle, int, int, int, int, GraphicsUnit);
internal delegate Color _0089_0003();
internal delegate int _008A_0003(Array, int);
internal delegate Type[] _008B_0003(object);
internal delegate Icon _008C_0003(IntPtr);
internal delegate string _008D_0003(string, int, int);
internal delegate int _008E_0003(double);
internal delegate Size _008F_0003(SizeF);
internal delegate void _0090_0003(ThreadExceptionEventHandler);
internal delegate object _0091_0003(object, string, object);
internal delegate FileStream _0092_0003(string);
internal delegate void _0093_0003(object, int, int, int, int);
internal delegate StringBuilder _0094_0003(object, char);
internal delegate int _0095_0003(Type);
internal delegate object[] _0096_0003(object, string, object[]);
internal delegate bool _0097_0003(object, object, ref object);
internal delegate Encoding _0098_0003();
internal delegate ModuleHandle _0099_0003(object);
internal delegate void _009A_0003(object, object, EventArgs);
internal delegate void _009B_0003(object, AnchorStyles);
internal delegate Delegate _009C_0003(Type, MethodInfo);
internal delegate Stream _009D_0003(object, string);
internal delegate StringBuilder _009E_0003(object, int);
internal delegate int _009F_0003(object, char);
internal delegate string _0001_0004(string, string, string);
internal delegate Assembly _0002_0004(object);
internal delegate Type _0003_0004(object, string);
internal delegate Module _0004_0004(object);
internal delegate string _0005_0004(string, string, string, int, int, CompareMethod);
internal delegate void _0006_0004(object, Cursor);
internal delegate bool _0007_0004(object, object);
internal delegate string _0008_0004(object, int, int);
internal delegate Version _000E_0004(object);
internal delegate string _000F_0004(string, string, string, string);
internal delegate void _0010_0004(object, byte);
internal delegate char _0011_0004(object, int);
internal delegate int _0012_0004(long);
internal delegate SizeF _0013_0004(object, string, Font, int);
internal delegate ICryptoTransform _0014_0004(object);
internal delegate void _0015_0004(Exception);
internal delegate void _0016_0004(object, object, object);
internal delegate void _0017_0004(object, IWebProxy);
internal delegate void _0018_0004(object, Control[]);
internal delegate Delegate _0019_0004(IntPtr, Type);
internal delegate void _001A_0004(object, CancelEventArgs);
internal delegate void _001B_0004(object, Icon);
internal delegate void _001C_0004(object, OpCode);
internal delegate void _001D_0004(object, Image);
internal delegate string _001E_0004(object, object, object);
internal delegate void _001F_0004(object, string, object, Type);
internal delegate StackFrame _007F_0004(object, int);
internal delegate object _0080_0004(object);
internal delegate void _0081_0004(object, Pen, int, int, int, int);
internal delegate void _0082_0004(object, PaintEventArgs);
internal delegate void _0083_0004(object, Font);
internal delegate Font _0084_0004(object);
internal delegate object _0086_0004(Type, bool);
internal delegate MethodInfo _0087_0004(object, string, Type[]);
internal delegate void _0088_0004(object, Control);
internal delegate byte[] _0089_0004(int);
internal delegate void _008A_0004(object, UnhandledExceptionEventHandler);
internal delegate object _008B_0004(object, string, BindingFlags, Binder, object, object[]);
internal delegate Pen _008C_0004();
internal delegate string _008D_0004(Type, object, string);
internal delegate bool _008E_0004(string);
internal delegate AssemblyName _008F_0004(object);
internal delegate short _0090_0004(byte[], int);
internal delegate object _0091_0004(object, int);
internal delegate Point _0092_0004(object);
internal delegate RegistryKey _0093_0004(object, string);
internal delegate Process _0094_0004();
internal delegate string _0095_0004(string, object);
internal delegate void _0096_0004(object);
internal delegate Delegate _0097_0004(object, Type);
internal delegate int _0098_0004(object);
internal delegate Process _0099_0004(string);
internal delegate void _009A_0004(object, byte[]);
internal delegate object _009B_0004(object, string, Type);
internal delegate int _009C_0004(IntPtr);
internal delegate int _009D_0004(string);
internal delegate int _009E_0004(float);
internal delegate string _009F_0004(string, object, object);
internal delegate ControlCollection _0001_0005(object);
internal delegate void _0002_0005(object, long);
internal delegate object _0003_0005(object, object, object[]);
internal delegate void _0004_0005(object, Control, string);
internal delegate int _0005_0005(object, int);
internal delegate void _0006_0005(object, bool);
internal delegate void _0007_0005(object, byte[], int, int);
internal delegate int _0008_0005(int, int);
internal delegate ParameterInfo[] _000E_0005(object);
internal delegate void _000F_0005(int);
internal delegate DialogResult _0010_0005(object);
internal delegate bool _0011_0005(object);
internal delegate Assembly _0012_0005();
internal delegate void _0013_0005(object, SerializationInfo, StreamingContext);
internal delegate DialogResult _0014_0005(string, string, MessageBoxButtons, MessageBoxIcon);
internal delegate string _0015_0005(object);
internal delegate Process _0016_0005(string, string);
internal delegate long _0017_0005(string);
internal delegate void _0018_0005(object, EventArgs);
