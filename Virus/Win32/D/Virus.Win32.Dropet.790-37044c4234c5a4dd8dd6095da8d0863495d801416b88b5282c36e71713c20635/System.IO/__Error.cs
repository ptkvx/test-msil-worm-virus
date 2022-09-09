using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.IO;

internal static class __Error
{
	internal static void EndOfFile()
	{
		throw new EndOfStreamException(SR.GetString("IO_EOF_ReadBeyondEOF"));
	}

	internal static void FileNotOpen()
	{
		throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_FileClosed"));
	}

	internal static void PipeNotOpen()
	{
		throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_PipeClosed"));
	}

	internal static void ReadNotSupported()
	{
		throw new NotSupportedException(SR.GetString("NotSupported_UnreadableStream"));
	}

	internal static void SeekNotSupported()
	{
		throw new NotSupportedException(SR.GetString("NotSupported_UnseekableStream"));
	}

	internal static void WrongAsyncResult()
	{
		throw new ArgumentException(SR.GetString("Argument_WrongAsyncResult"));
	}

	internal static void EndReadCalledTwice()
	{
		throw new ArgumentException(SR.GetString("InvalidOperation_EndReadCalledMultiple"));
	}

	internal static void EndWriteCalledTwice()
	{
		throw new ArgumentException(SR.GetString("InvalidOperation_EndWriteCalledMultiple"));
	}

	internal static void EndWaitForConnectionCalledTwice()
	{
		throw new ArgumentException(SR.GetString("InvalidOperation_EndWaitForConnectionCalledMultiple"));
	}

	internal static string GetDisplayablePath(string path, bool isInvalidPath)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(path))
		{
			return path;
		}
		bool flag = false;
		if (path.Length < 2)
		{
			return path;
		}
		if (path[0] == Path.DirectorySeparatorChar && path[1] == Path.DirectorySeparatorChar)
		{
			flag = true;
		}
		else if (path[1] == Path.VolumeSeparatorChar)
		{
			flag = true;
		}
		if (!flag && !isInvalidPath)
		{
			return path;
		}
		bool flag2 = false;
		try
		{
			if (!isInvalidPath)
			{
				((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)8, new string[1] { path })).Demand();
				flag2 = true;
			}
		}
		catch (SecurityException)
		{
		}
		catch (ArgumentException)
		{
		}
		catch (NotSupportedException)
		{
		}
		if (!flag2)
		{
			path = ((path[path.Length - 1] != Path.DirectorySeparatorChar) ? Path.GetFileName(path) : SR.GetString("IO_IO_NoPermissionToDirectoryName"));
		}
		return path;
	}

	[SecurityCritical]
	internal static void WinIOError()
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		WinIOError(lastWin32Error, string.Empty);
	}

	[SecurityCritical]
	internal static void WinIOError(int errorCode, string maybeFullPath)
	{
		bool isInvalidPath = errorCode == 123 || errorCode == 161;
		string displayablePath = GetDisplayablePath(maybeFullPath, isInvalidPath);
		switch (errorCode)
		{
		case 15:
			throw new DriveNotFoundException(string.Format(CultureInfo.CurrentCulture, SR.GetString("IO_DriveNotFound_Drive"), new object[1] { displayablePath }));
		case 2:
			if (displayablePath.Length == 0)
			{
				throw new FileNotFoundException(SR.GetString("IO_FileNotFound"));
			}
			throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture, SR.GetString("IO_FileNotFound_FileName"), new object[1] { displayablePath }), displayablePath);
		case 3:
			if (displayablePath.Length == 0)
			{
				throw new DirectoryNotFoundException(SR.GetString("IO_PathNotFound_NoPathName"));
			}
			throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture, SR.GetString("IO_PathNotFound_Path"), new object[1] { displayablePath }));
		case 5:
			if (displayablePath.Length == 0)
			{
				throw new UnauthorizedAccessException(SR.GetString("UnauthorizedAccess_IODenied_NoPathName"));
			}
			throw new UnauthorizedAccessException(string.Format(CultureInfo.CurrentCulture, SR.GetString("UnauthorizedAccess_IODenied_Path"), new object[1] { displayablePath }));
		case 80:
			if (displayablePath.Length != 0)
			{
				throw new IOException(string.Format(CultureInfo.CurrentCulture, SR.GetString("IO_IO_FileExists_Name"), new object[1] { displayablePath }), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			goto default;
		case 32:
			if (displayablePath.Length == 0)
			{
				throw new IOException(SR.GetString("IO_IO_SharingViolation_NoFileName"), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			throw new IOException(SR.GetString("IO_IO_SharingViolation_File", displayablePath), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		case 183:
			if (displayablePath.Length != 0)
			{
				throw new IOException(SR.GetString("IO_IO_AlreadyExists_Name", displayablePath), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			goto default;
		case 87:
			throw new IOException(UnsafeNativeMethods.GetMessage(errorCode), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		default:
			throw new IOException(UnsafeNativeMethods.GetMessage(errorCode), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		case 995:
			throw new OperationCanceledException();
		case 206:
			throw new PathTooLongException(SR.GetString("IO_PathTooLong"));
		}
	}

	internal static void WriteNotSupported()
	{
		throw new NotSupportedException(SR.GetString("NotSupported_UnwritableStream"));
	}
}
