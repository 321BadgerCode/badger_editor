//badger
using System;
using System.Reflection;
using System.Reflection.Emit;

/*public partial class AssemblyBuilder
{
	[Obsolete("[._.]: ERROR: ASSEMBLY LEVEL DECLARATIVE SECURITY IS OBSOLETE AND IS NO LONGER ENFORCED BY THE C.L.R DEFAULT!")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access) { return null; }
	public static void Main()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += new ResolveEventHandler(MyResolveEventHandler);
		InstantiateMyDynamicType(currentDomain);
	}
	static void InstantiateMyDynamicType(AppDomain domain)
	{
		try
		{
			// You must supply a valid fully qualified assembly name here.
			domain.CreateInstance("Assembly text name, Version, Culture, PublicKeyToken", "MyDynamicType");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
	{
		return DefineDynamicAssembly((AppDomain)sender);
	}
	static Assembly DefineDynamicAssembly(AppDomain domain)
	{
		// Build a dynamic assembly using Reflection Emit API.

		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = "MyDynamicAssembly";

		AssemblyBuilder assemblyBuilder = domain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
		ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MyDynamicModule");
		TypeBuilder typeBuilder = moduleBuilder.DefineType("MyDynamicType", TypeAttributes.Public);
		ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, null);
		ILGenerator ilGenerator = constructorBuilder.GetILGenerator();

		ilGenerator.EmitWriteLine("MyDynamicType instantiated!");
		ilGenerator.Emit(OpCodes.Ret);

		typeBuilder.CreateType();

		return assemblyBuilder;
	}

	public static void Main()
	{
		AssemblyName aName = new AssemblyName("DynamicAssemblyExample");
		AssemblyBuilder ab = AppDomain.CurrentDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.RunAndCollect);//AssemblyBuilderAccess.RunAndSave

		ModuleBuilder mb =
		    ab.DefineDynamicModule(aName.Name, aName.Name + ".dll");

		TypeBuilder tb = mb.DefineType(
		    "MyDynamicType",
		     TypeAttributes.Public);

		FieldBuilder fbNumber = tb.DefineField(
		    "m_number",
		    typeof(int),
		    FieldAttributes.Private);

		Type[] parameterTypes = { typeof(int) };
		ConstructorBuilder ctor1 = tb.DefineConstructor(
		    MethodAttributes.Public,
		    CallingConventions.Standard,
		    parameterTypes);

		ILGenerator ctor1IL = ctor1.GetILGenerator();

		ctor1IL.Emit(OpCodes.Ldarg_0);
		ctor1IL.Emit(OpCodes.Call, typeof(object).GetConstructor(Type.EmptyTypes));
		ctor1IL.Emit(OpCodes.Ldarg_0);
		ctor1IL.Emit(OpCodes.Ldarg_1);
		ctor1IL.Emit(OpCodes.Stfld, fbNumber);
		ctor1IL.Emit(OpCodes.Ret);

		ConstructorBuilder ctor0 = tb.DefineConstructor(
		    MethodAttributes.Public,
		    CallingConventions.Standard,
		    Type.EmptyTypes);

		ILGenerator ctor0IL = ctor0.GetILGenerator();

		ctor0IL.Emit(OpCodes.Ldarg_0);
		ctor0IL.Emit(OpCodes.Ldc_I4_S, 42);
		ctor0IL.Emit(OpCodes.Call, ctor1);
		ctor0IL.Emit(OpCodes.Ret);

		PropertyBuilder pbNumber = tb.DefineProperty(
		    "Number",
		    PropertyAttributes.HasDefault,
		    typeof(int),
		    null);

		MethodAttributes getSetAttr = MethodAttributes.Public |
		    MethodAttributes.SpecialName | MethodAttributes.HideBySig;

		MethodBuilder mbNumberGetAccessor = tb.DefineMethod(
		    "get_Number",
		    getSetAttr,
		    typeof(int),
		    Type.EmptyTypes);

		ILGenerator numberGetIL = mbNumberGetAccessor.GetILGenerator();

		numberGetIL.Emit(OpCodes.Ldarg_0);
		numberGetIL.Emit(OpCodes.Ldfld, fbNumber);
		numberGetIL.Emit(OpCodes.Ret);

		MethodBuilder mbNumberSetAccessor = tb.DefineMethod(
		    "set_Number",
		    getSetAttr,
		    null,
		    new Type[] { typeof(int) });

		ILGenerator numberSetIL = mbNumberSetAccessor.GetILGenerator();

		numberSetIL.Emit(OpCodes.Ldarg_0);
		numberSetIL.Emit(OpCodes.Ldarg_1);
		numberSetIL.Emit(OpCodes.Stfld, fbNumber);
		numberSetIL.Emit(OpCodes.Ret);

		pbNumber.SetGetMethod(mbNumberGetAccessor);
		pbNumber.SetSetMethod(mbNumberSetAccessor);

		MethodBuilder meth = tb.DefineMethod(
		    "MyMethod",
		    MethodAttributes.Public,
		    typeof(int),
		    new Type[] { typeof(int) });

		ILGenerator methIL = meth.GetILGenerator();

		methIL.Emit(OpCodes.Ldarg_0);
		methIL.Emit(OpCodes.Ldfld, fbNumber);
		methIL.Emit(OpCodes.Ldarg_1);
		methIL.Emit(OpCodes.Mul);
		methIL.Emit(OpCodes.Ret);

		Type t = tb.CreateType();

		ab.Save(aName.Name + ".dll");

		MethodInfo mi = t.GetMethod("MyMethod");
		PropertyInfo pi = t.GetProperty("Number");

		object o1 = Activator.CreateInstance(t);

		Console.WriteLine("o1.Number: {0}", pi.GetValue(o1, null));
		pi.SetValue(o1, 127, null);
		Console.WriteLine("o1.Number: {0}", pi.GetValue(o1, null));

		object[] arguments = { 22 };
		Console.WriteLine("o1.MyMethod(22): {0}",
		    mi.Invoke(o1, arguments));

		object o2 = Activator.CreateInstance(t,
		    new object[] { 5280 });
		Console.WriteLine("o2.Number: {0}", pi.GetValue(o2, null));
	}
};*/
//https://docs.microsoft.com/en-us/dotnet/api/system.reflection.emit.assemblybuilder?view=netcore-3.1
//https://docs.microsoft.com/en-us/dotnet/api/system.appdomain.definedynamicassembly?view=netframework-4.8#System_AppDomain_DefineDynamicAssembly_System_Reflection_AssemblyName_System_Reflection_Emit_AssemblyBuilderAccess_