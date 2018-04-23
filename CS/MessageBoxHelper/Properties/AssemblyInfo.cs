// Developer Express Code Central Example:
// How to create a custom XtraMessageBox with the extended functionality
// 
// This example demonstrates how to create a MessageBox with an extended
// functionality. For this, create MyXtraMessageBox class descendant that is
// inherited from the XtraMessageBox class and uses the XtraMessageBoxArgs class -
// a MyXtraMessageArgs descendant which contains properties to customize the
// XtraMessageBox behavior. - ShowCountDown. If this property is true, the message
// box title will show you how many seconds are left before the timeout. When the
// countdown is over, the title will show its usual value.
// - ShowNextTime. This
// property allows you to show a CheckBox on your message form. When you close the
// form, the result will be saved in the ShowMessageNextTime property of
// MyXtraMessageArgs and you can use this value later.
// - DisableButtons. If this
// property value is true, all buttons except for "Cancel" will be disabled on the
// form.
// - DisableCancel. This property gives you an opportunity to disable the
// "Cancel" button on the form.
// - AutoClose. If you want to close your form, after
// the countdown is over, set this property to true. Also, you need to define the
// value of the AutoCloseResult property. This property shows what value will be
// received from the MyXtraMessageBox.Show method if the form is automatically
// closed.
// - Center. If this property value is true, the MessageBox will be center
// aligned against its parent form.
// - Timeout. This property sets the timer for
// the AutoClose and ShowCountDown properties in seconds. Its value should be
// greater than 0, otherwise, these properties will be unavailable.
// - Buttons.
// This property specifies what buttons will be available on the form.
// - Icon.
// This property specifies the MessageBox icon.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T229906

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MessageBoxHelper")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("MessageBoxHelper")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9006f149-aa49-4b8e-ba69-386d945fa738")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
