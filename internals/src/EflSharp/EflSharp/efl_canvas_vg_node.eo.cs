#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Canvas { namespace Vg { 
/// <summary>Efl vector graphics abstract class</summary>
[NodeNativeInherit]
public class Node : Efl.Object, Efl.Eo.IWrapper,Efl.Duplicate,Efl.Gfx.Color,Efl.Gfx.Entity,Efl.Gfx.Path,Efl.Gfx.Stack
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Canvas.Vg.NodeNativeInherit nativeInherit = new Efl.Canvas.Vg.NodeNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (Node))
            return Efl.Canvas.Vg.NodeNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
      efl_canvas_vg_node_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   public Node(Efl.Object parent= null
         ) :
      base(efl_canvas_vg_node_class_get(), typeof(Node), parent)
   {
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public Node(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected Node(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static Node static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new Node(obj.NativeHandle);
   }
   ///<summary>Verifies if the given object is equal to this one.</summary>
   public override bool Equals(object obj)
   {
      var other = obj as Efl.Object;
      if (other == null)
         return false;
      return this.NativeHandle == other.NativeHandle;
   }
   ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
   public override int GetHashCode()
   {
      return this.NativeHandle.ToInt32();
   }
   ///<summary>Turns the native pointer into a string representation.</summary>
   public override String ToString()
   {
      return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
   }
private static object VisibilityChangedEvtKey = new object();
   /// <summary>Object&apos;s visibility state changed, the event value is the new state.</summary>
   public event EventHandler<Efl.Gfx.EntityVisibilityChangedEvt_Args> VisibilityChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_VISIBILITY_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_VisibilityChangedEvt_delegate)) {
               eventHandlers.AddHandler(VisibilityChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_VISIBILITY_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_VisibilityChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(VisibilityChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event VisibilityChangedEvt.</summary>
   public void On_VisibilityChangedEvt(Efl.Gfx.EntityVisibilityChangedEvt_Args e)
   {
      EventHandler<Efl.Gfx.EntityVisibilityChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Gfx.EntityVisibilityChangedEvt_Args>)eventHandlers[VisibilityChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_VisibilityChangedEvt_delegate;
   private void on_VisibilityChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Gfx.EntityVisibilityChangedEvt_Args args = new Efl.Gfx.EntityVisibilityChangedEvt_Args();
      args.arg = evt.Info != IntPtr.Zero;
      try {
         On_VisibilityChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object PositionChangedEvtKey = new object();
   /// <summary>Object was moved, its position during the event is the new one.</summary>
   public event EventHandler<Efl.Gfx.EntityPositionChangedEvt_Args> PositionChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_POSITION_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_PositionChangedEvt_delegate)) {
               eventHandlers.AddHandler(PositionChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_POSITION_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_PositionChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(PositionChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event PositionChangedEvt.</summary>
   public void On_PositionChangedEvt(Efl.Gfx.EntityPositionChangedEvt_Args e)
   {
      EventHandler<Efl.Gfx.EntityPositionChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Gfx.EntityPositionChangedEvt_Args>)eventHandlers[PositionChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_PositionChangedEvt_delegate;
   private void on_PositionChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Gfx.EntityPositionChangedEvt_Args args = new Efl.Gfx.EntityPositionChangedEvt_Args();
      args.arg =  evt.Info;;
      try {
         On_PositionChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object SizeChangedEvtKey = new object();
   /// <summary>Object was resized, its size during the event is the new one.</summary>
   public event EventHandler<Efl.Gfx.EntitySizeChangedEvt_Args> SizeChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_SIZE_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_SizeChangedEvt_delegate)) {
               eventHandlers.AddHandler(SizeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_SIZE_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_SizeChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(SizeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event SizeChangedEvt.</summary>
   public void On_SizeChangedEvt(Efl.Gfx.EntitySizeChangedEvt_Args e)
   {
      EventHandler<Efl.Gfx.EntitySizeChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Gfx.EntitySizeChangedEvt_Args>)eventHandlers[SizeChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_SizeChangedEvt_delegate;
   private void on_SizeChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Gfx.EntitySizeChangedEvt_Args args = new Efl.Gfx.EntitySizeChangedEvt_Args();
      args.arg =  evt.Info;;
      try {
         On_SizeChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object StackingChangedEvtKey = new object();
   /// <summary>Object stacking was changed.</summary>
   public event EventHandler StackingChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_STACKING_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_StackingChangedEvt_delegate)) {
               eventHandlers.AddHandler(StackingChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_GFX_ENTITY_EVENT_STACKING_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_StackingChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(StackingChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event StackingChangedEvt.</summary>
   public void On_StackingChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[StackingChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_StackingChangedEvt_delegate;
   private void on_StackingChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_StackingChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

   protected override void register_event_proxies()
   {
      base.register_event_proxies();
      evt_VisibilityChangedEvt_delegate = new Efl.EventCb(on_VisibilityChangedEvt_NativeCallback);
      evt_PositionChangedEvt_delegate = new Efl.EventCb(on_PositionChangedEvt_NativeCallback);
      evt_SizeChangedEvt_delegate = new Efl.EventCb(on_SizeChangedEvt_NativeCallback);
      evt_StackingChangedEvt_delegate = new Efl.EventCb(on_StackingChangedEvt_NativeCallback);
   }
   /// <summary>Gets the transformation matrix used for this node object.
   /// 1.14</summary>
   /// <returns>Transformation matrix.</returns>
   virtual public Eina.Matrix3 GetTransformation() {
       var _ret_var = Efl.Canvas.Vg.NodeNativeInherit.efl_canvas_vg_node_transformation_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      var __ret_tmp = Eina.PrimitiveConversion.PointerToManaged<Eina.Matrix3>(_ret_var);
      
      return __ret_tmp;
 }
   /// <summary>Sets the transformation matrix to be used for this node object.
   /// Note: Pass <c>null</c> to cancel the applied transformation.
   /// 1.14</summary>
   /// <param name="m">Transformation matrix.</param>
   /// <returns></returns>
   virtual public  void SetTransformation( ref Eina.Matrix3 m) {
       var _in_m = Eina.Matrix3_StructConversion.ToInternal(m);
                  Efl.Canvas.Vg.NodeNativeInherit.efl_canvas_vg_node_transformation_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), ref _in_m);
      Eina.Error.RaiseIfUnhandledException();
            m = Eina.Matrix3_StructConversion.ToManaged(_in_m);
       }
   /// <summary>Gets the origin position of the node object.
   /// 1.14</summary>
   /// <param name="x"><c>origin</c> x position.</param>
   /// <param name="y"><c>origin</c> y position.</param>
   /// <returns></returns>
   virtual public  void GetOrigin( out double x,  out double y) {
                                           Efl.Canvas.Vg.NodeNativeInherit.efl_canvas_vg_node_origin_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Sets the origin position of the node object.
   /// This origin position affects node transformation.
   /// 1.14</summary>
   /// <param name="x"><c>origin</c> x position.</param>
   /// <param name="y"><c>origin</c> y position.</param>
   /// <returns></returns>
   virtual public  void SetOrigin( double x,  double y) {
                                           Efl.Canvas.Vg.NodeNativeInherit.efl_canvas_vg_node_origin_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set Mask Node to this renderer</summary>
   /// <param name="mask">Mask object</param>
   /// <param name="op">Masking Option. Reserved</param>
   /// <returns></returns>
   virtual public  void SetMask( Efl.Canvas.Vg.Node mask,   int op) {
                                           Efl.Canvas.Vg.NodeNativeInherit.efl_canvas_vg_node_mask_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), mask,  op);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Creates a carbon copy of this object and returns it.
   /// The newly created object will have no event handlers or anything of the sort.</summary>
   /// <returns>Returned carbon copy</returns>
   virtual public Efl.Duplicate DoDuplicate() {
       var _ret_var = Efl.DuplicateNativeInherit.efl_duplicate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Retrieves the general/main color of the given Evas object.
   /// Retrieves the main color&apos;s RGB component (and alpha channel) values, which range from 0 to 255. For the alpha channel, which defines the object&apos;s transparency level, 0 means totally transparent, while 255 means opaque. These color values are premultiplied by the alpha value.
   /// 
   /// Usually youll use this attribute for text and rectangle objects, where the main color is their unique one. If set for objects which themselves have colors, like the images one, those colors get modulated by this one.
   /// 
   /// All newly created Evas rectangles get the default color values of 255 255 255 255 (opaque white).
   /// 
   /// Use null pointers on the components you&apos;re not interested in: they&apos;ll be ignored by the function.</summary>
   /// <param name="r"></param>
   /// <param name="g"></param>
   /// <param name="b"></param>
   /// <param name="a"></param>
   /// <returns></returns>
   virtual public  void GetColor( out  int r,  out  int g,  out  int b,  out  int a) {
                                                                               Efl.Gfx.ColorNativeInherit.efl_gfx_color_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out r,  out g,  out b,  out a);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Sets the general/main color of the given Evas object to the given one.
   /// See also <see cref="Efl.Gfx.Color.GetColor"/> (for an example)
   /// 
   /// These color values are expected to be premultiplied by alpha.</summary>
   /// <param name="r"></param>
   /// <param name="g"></param>
   /// <param name="b"></param>
   /// <param name="a"></param>
   /// <returns></returns>
   virtual public  void SetColor(  int r,   int g,   int b,   int a) {
                                                                               Efl.Gfx.ColorNativeInherit.efl_gfx_color_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), r,  g,  b,  a);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Get hex color code of given Evas object. This returns a short lived hex color code string.</summary>
   /// <returns>the hex color code.</returns>
   virtual public  System.String GetColorCode() {
       var _ret_var = Efl.Gfx.ColorNativeInherit.efl_gfx_color_code_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Set the color of given Evas object to the given hex color code(#RRGGBBAA). e.g. efl_gfx_color_code_set(obj, &quot;#FFCCAACC&quot;);</summary>
   /// <param name="colorcode">the hex color code.</param>
   /// <returns></returns>
   virtual public  void SetColorCode(  System.String colorcode) {
                         Efl.Gfx.ColorNativeInherit.efl_gfx_color_code_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), colorcode);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Retrieves the position of the given canvas object.</summary>
   /// <returns>A 2D coordinate in pixel units.</returns>
   virtual public Eina.Position2D GetPosition() {
       var _ret_var = Efl.Gfx.EntityNativeInherit.efl_gfx_entity_position_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Position2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Moves the given canvas object to the given location inside its canvas&apos; viewport. If unchanged this call may be entirely skipped, but if changed this will trigger move events, as well as potential pointer,in or pointer,out events.</summary>
   /// <param name="pos">A 2D coordinate in pixel units.</param>
   /// <returns></returns>
   virtual public  void SetPosition( Eina.Position2D pos) {
       var _in_pos = Eina.Position2D_StructConversion.ToInternal(pos);
                  Efl.Gfx.EntityNativeInherit.efl_gfx_entity_position_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_pos);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Retrieves the (rectangular) size of the given Evas object.</summary>
   /// <returns>A 2D size in pixel units.</returns>
   virtual public Eina.Size2D GetSize() {
       var _ret_var = Efl.Gfx.EntityNativeInherit.efl_gfx_entity_size_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Size2D_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Changes the size of the given object.
   /// Note that setting the actual size of an object might be the job of its container, so this function might have no effect. Look at <see cref="Efl.Gfx.Hint"/> instead, when manipulating widgets.</summary>
   /// <param name="size">A 2D size in pixel units.</param>
   /// <returns></returns>
   virtual public  void SetSize( Eina.Size2D size) {
       var _in_size = Eina.Size2D_StructConversion.ToInternal(size);
                  Efl.Gfx.EntityNativeInherit.efl_gfx_entity_size_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_size);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Rectangular geometry that combines both position and size.</summary>
   /// <returns>The X,Y position and W,H size, in pixels.</returns>
   virtual public Eina.Rect GetGeometry() {
       var _ret_var = Efl.Gfx.EntityNativeInherit.efl_gfx_entity_geometry_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return Eina.Rect_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Rectangular geometry that combines both position and size.</summary>
   /// <param name="rect">The X,Y position and W,H size, in pixels.</param>
   /// <returns></returns>
   virtual public  void SetGeometry( Eina.Rect rect) {
       var _in_rect = Eina.Rect_StructConversion.ToInternal(rect);
                  Efl.Gfx.EntityNativeInherit.efl_gfx_entity_geometry_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_rect);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Retrieves whether or not the given canvas object is visible.</summary>
   /// <returns><c>true</c> if to make the object visible, <c>false</c> otherwise</returns>
   virtual public bool GetVisible() {
       var _ret_var = Efl.Gfx.EntityNativeInherit.efl_gfx_entity_visible_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Shows or hides this object.</summary>
   /// <param name="v"><c>true</c> if to make the object visible, <c>false</c> otherwise</param>
   /// <returns></returns>
   virtual public  void SetVisible( bool v) {
                         Efl.Gfx.EntityNativeInherit.efl_gfx_entity_visible_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), v);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Gets an object&apos;s scaling factor.</summary>
   /// <returns>The scaling factor (the default value is 0.0, meaning individual scaling is not set)</returns>
   virtual public double GetScale() {
       var _ret_var = Efl.Gfx.EntityNativeInherit.efl_gfx_entity_scale_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Sets the scaling factor of an object.</summary>
   /// <param name="scale">The scaling factor (the default value is 0.0, meaning individual scaling is not set)</param>
   /// <returns></returns>
   virtual public  void SetScale( double scale) {
                         Efl.Gfx.EntityNativeInherit.efl_gfx_entity_scale_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), scale);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the list of commands and points to be used to create the content of path.
   /// 1.18</summary>
   /// <param name="op">Command list</param>
   /// <param name="points">Point list</param>
   /// <returns></returns>
   virtual public  void GetPath( out Efl.Gfx.PathCommandType op,  out double points) {
                   System.IntPtr _out_op = System.IntPtr.Zero;
      System.IntPtr _out_points = System.IntPtr.Zero;
                  Efl.Gfx.PathNativeInherit.efl_gfx_path_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out _out_op,  out _out_points);
      Eina.Error.RaiseIfUnhandledException();
      op = Eina.PrimitiveConversion.PointerToManaged<Efl.Gfx.PathCommandType>(_out_op);
      points = Eina.PrimitiveConversion.PointerToManaged<double>(_out_points);
                   }
   /// <summary>Set the list of commands and points to be used to create the content of path.
   /// 1.18</summary>
   /// <param name="op">Command list</param>
   /// <param name="points">Point list</param>
   /// <returns></returns>
   virtual public  void SetPath( Efl.Gfx.PathCommandType op,  double points) {
       var _in_op = Eina.PrimitiveConversion.ManagedToPointerAlloc(op);
      var _in_points = Eina.PrimitiveConversion.ManagedToPointerAlloc(points);
                              Efl.Gfx.PathNativeInherit.efl_gfx_path_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_op,  _in_points);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Path length property</summary>
   /// <param name="commands">Commands</param>
   /// <param name="points">Points</param>
   /// <returns></returns>
   virtual public  void GetLength( out  uint commands,  out  uint points) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_length_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out commands,  out points);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Current point coordinates</summary>
   /// <param name="x">X co-ordinate of the current point.</param>
   /// <param name="y">Y co-ordinate of the current point.</param>
   /// <returns></returns>
   virtual public  void GetCurrent( out double x,  out double y) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_current_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Current control point coordinates</summary>
   /// <param name="x">X co-ordinate of control point.</param>
   /// <param name="y">Y co-ordinate of control point.</param>
   /// <returns></returns>
   virtual public  void GetCurrentCtrl( out double x,  out double y) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_current_ctrl_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Copy the path data from the object specified.
   /// 1.18</summary>
   /// <param name="dup_from">Shape object from where data will be copied.</param>
   /// <returns></returns>
   virtual public  void CopyFrom( Efl.Object dup_from) {
                         Efl.Gfx.PathNativeInherit.efl_gfx_path_copy_from_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), dup_from);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Compute and return the bounding box of the currently set path
   /// 1.18</summary>
   /// <param name="r">Contain the bounding box of the currently set path</param>
   /// <returns></returns>
   virtual public  void GetBounds( out Eina.Rect r) {
             var _out_r = new Eina.Rect_StructInternal();
            Efl.Gfx.PathNativeInherit.efl_gfx_path_bounds_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), out _out_r);
      Eina.Error.RaiseIfUnhandledException();
      r = Eina.Rect_StructConversion.ToManaged(_out_r);
             }
   /// <summary>Reset the path data of the path object.
   /// 1.18</summary>
   /// <returns></returns>
   virtual public  void Reset() {
       Efl.Gfx.PathNativeInherit.efl_gfx_path_reset_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Moves the current point to the given point,  implicitly starting a new subpath and closing the previous one.
   /// See also <see cref="Efl.Gfx.Path.CloseAppend"/>.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of the current point.</param>
   /// <param name="y">Y co-ordinate of the current point.</param>
   /// <returns></returns>
   virtual public  void AppendMoveTo( double x,  double y) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_append_move_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Adds a straight line from the current position to the given end point. After the line is drawn, the current position is updated to be at the end point of the line.
   /// If no current position present, it draws a line to itself, basically a point.
   /// 
   /// See also <see cref="Efl.Gfx.Path.AppendMoveTo"/>.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of end point of the line.</param>
   /// <param name="y">Y co-ordinate of end point of the line.</param>
   /// <returns></returns>
   virtual public  void AppendLineTo( double x,  double y) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_append_line_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Adds a quadratic Bezier curve between the current position and the given end point (x,y) using the control points specified by (ctrl_x, ctrl_y). After the path is drawn, the current position is updated to be at the end point of the path.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of end point of the line.</param>
   /// <param name="y">Y co-ordinate of end point of the line.</param>
   /// <param name="ctrl_x">X co-ordinate of control point.</param>
   /// <param name="ctrl_y">Y co-ordinate of control point.</param>
   /// <returns></returns>
   virtual public  void AppendQuadraticTo( double x,  double y,  double ctrl_x,  double ctrl_y) {
                                                                               Efl.Gfx.PathNativeInherit.efl_gfx_path_append_quadratic_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  ctrl_x,  ctrl_y);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Same as efl_gfx_path_append_quadratic_to() api only difference is that it uses the current control point to draw the bezier.
   /// See also <see cref="Efl.Gfx.Path.AppendQuadraticTo"/>.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of end point of the line.</param>
   /// <param name="y">Y co-ordinate of end point of the line.</param>
   /// <returns></returns>
   virtual public  void AppendSquadraticTo( double x,  double y) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_append_squadratic_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Adds a cubic Bezier curve between the current position and the given end point (x,y) using the control points specified by (ctrl_x0, ctrl_y0), and (ctrl_x1, ctrl_y1). After the path is drawn, the current position is updated to be at the end point of the path.
   /// 1.18</summary>
   /// <param name="ctrl_x0">X co-ordinate of 1st control point.</param>
   /// <param name="ctrl_y0">Y co-ordinate of 1st control point.</param>
   /// <param name="ctrl_x1">X co-ordinate of 2nd control point.</param>
   /// <param name="ctrl_y1">Y co-ordinate of 2nd control point.</param>
   /// <param name="x">X co-ordinate of end point of the line.</param>
   /// <param name="y">Y co-ordinate of end point of the line.</param>
   /// <returns></returns>
   virtual public  void AppendCubicTo( double ctrl_x0,  double ctrl_y0,  double ctrl_x1,  double ctrl_y1,  double x,  double y) {
                                                                                                                   Efl.Gfx.PathNativeInherit.efl_gfx_path_append_cubic_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), ctrl_x0,  ctrl_y0,  ctrl_x1,  ctrl_y1,  x,  y);
      Eina.Error.RaiseIfUnhandledException();
                                                                               }
   /// <summary>Same as efl_gfx_path_append_cubic_to() api only difference is that it uses the current control point to draw the bezier.
   /// See also <see cref="Efl.Gfx.Path.AppendCubicTo"/>.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of end point of the line.</param>
   /// <param name="y">Y co-ordinate of end point of the line.</param>
   /// <param name="ctrl_x">X co-ordinate of 2nd control point.</param>
   /// <param name="ctrl_y">Y co-ordinate of 2nd control point.</param>
   /// <returns></returns>
   virtual public  void AppendScubicTo( double x,  double y,  double ctrl_x,  double ctrl_y) {
                                                                               Efl.Gfx.PathNativeInherit.efl_gfx_path_append_scubic_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  ctrl_x,  ctrl_y);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Append an arc that connects from the current point int the point list to the given point (x,y). The arc is defined by the given radius in  x-direction (rx) and radius in y direction (ry).
   /// Use this api if you know the end point&apos;s of the arc otherwise use more convenient function <see cref="Efl.Gfx.Path.AppendArc"/>.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of end point of the arc.</param>
   /// <param name="y">Y co-ordinate of end point of the arc.</param>
   /// <param name="rx">Radius of arc in x direction.</param>
   /// <param name="ry">Radius of arc in y direction.</param>
   /// <param name="angle">X-axis rotation , normally 0.</param>
   /// <param name="large_arc">Defines whether to draw the larger arc or smaller arc joining two point.</param>
   /// <param name="sweep">Defines whether the arc will be drawn counter-clockwise or clockwise from current point to the end point taking into account the large_arc property.</param>
   /// <returns></returns>
   virtual public  void AppendArcTo( double x,  double y,  double rx,  double ry,  double angle,  bool large_arc,  bool sweep) {
                                                                                                                                     Efl.Gfx.PathNativeInherit.efl_gfx_path_append_arc_to_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  rx,  ry,  angle,  large_arc,  sweep);
      Eina.Error.RaiseIfUnhandledException();
                                                                                           }
   /// <summary>Append an arc that enclosed in the given rectangle (x, y, w, h). The angle is defined in counter clock wise , use -ve angle for clockwise arc.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of the rect.</param>
   /// <param name="y">Y co-ordinate of the rect.</param>
   /// <param name="w">Width of the rect.</param>
   /// <param name="h">Height of the rect.</param>
   /// <param name="start_angle">Angle at which the arc will start</param>
   /// <param name="sweep_length">@ Length of the arc.</param>
   /// <returns></returns>
   virtual public  void AppendArc( double x,  double y,  double w,  double h,  double start_angle,  double sweep_length) {
                                                                                                                   Efl.Gfx.PathNativeInherit.efl_gfx_path_append_arc_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  w,  h,  start_angle,  sweep_length);
      Eina.Error.RaiseIfUnhandledException();
                                                                               }
   /// <summary>Closes the current subpath by drawing a line to the beginning of the subpath, automatically starting a new path. The current point of the new path is (0, 0).
   /// If the subpath does not contain any points, this function does nothing.
   /// 1.18</summary>
   /// <returns></returns>
   virtual public  void CloseAppend() {
       Efl.Gfx.PathNativeInherit.efl_gfx_path_append_close_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Append a circle with given center and radius.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of the center of the circle.</param>
   /// <param name="y">Y co-ordinate of the center of the circle.</param>
   /// <param name="radius">Radius of the circle.</param>
   /// <returns></returns>
   virtual public  void AppendCircle( double x,  double y,  double radius) {
                                                             Efl.Gfx.PathNativeInherit.efl_gfx_path_append_circle_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  radius);
      Eina.Error.RaiseIfUnhandledException();
                                           }
   /// <summary>Append the given rectangle with rounded corner to the path.
   /// The xr and yr arguments specify the radii of the ellipses defining the corners of the rounded rectangle.
   /// 
   /// xr and yr are specified in terms of width and height respectively.
   /// 
   /// If xr and yr are 0, then it will draw a rectangle without rounded corner.
   /// 1.18</summary>
   /// <param name="x">X co-ordinate of the rectangle.</param>
   /// <param name="y">Y co-ordinate of the rectangle.</param>
   /// <param name="w">Width of the rectangle.</param>
   /// <param name="h">Height of the rectangle.</param>
   /// <param name="rx">The x radius of the rounded corner and should be in range [ 0 to w/2 ]</param>
   /// <param name="ry">The y radius of the rounded corner and should be in range [ 0 to h/2 ]</param>
   /// <returns></returns>
   virtual public  void AppendRect( double x,  double y,  double w,  double h,  double rx,  double ry) {
                                                                                                                   Efl.Gfx.PathNativeInherit.efl_gfx_path_append_rect_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), x,  y,  w,  h,  rx,  ry);
      Eina.Error.RaiseIfUnhandledException();
                                                                               }
   /// <summary>Append SVG path data</summary>
   /// <param name="svg_path_data">SVG path data to append</param>
   /// <returns></returns>
   virtual public  void AppendSvgPath(  System.String svg_path_data) {
                         Efl.Gfx.PathNativeInherit.efl_gfx_path_append_svg_path_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), svg_path_data);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Creates intermediary path part-way between two paths
   /// Sets the points of the <c>obj</c> as the linear interpolation of the points in the <c>from</c> and <c>to</c> paths.  The path&apos;s x,y position and control point coordinates are likewise interpolated.
   /// 
   /// The <c>from</c> and <c>to</c> paths must not already have equivalent points, and <c>to</c> must contain at least as many points as <c>from</c>, else the function returns <c>false</c> with no interpolation performed.  If <c>to</c> has more points than <c>from</c>, the excess points are ignored.</summary>
   /// <param name="from">Source path</param>
   /// <param name="to">Destination path</param>
   /// <param name="pos_map">Position map in range 0.0 to 1.0</param>
   /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
   virtual public bool Interpolate( Efl.Object from,  Efl.Object to,  double pos_map) {
                                                             var _ret_var = Efl.Gfx.PathNativeInherit.efl_gfx_path_interpolate_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), from,  to,  pos_map);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Equal commands in object</summary>
   /// <param name="with">Object</param>
   /// <returns>True on success, <c>false</c> otherwise</returns>
   virtual public bool EqualCommands( Efl.Object with) {
                         var _ret_var = Efl.Gfx.PathNativeInherit.efl_gfx_path_equal_commands_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), with);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Reserve path commands buffer in advance. If you know the count of path commands coming, you can reserve commands buffer in advance to avoid buffer growing job.
   /// 1.22</summary>
   /// <param name="cmd_count">Commands count to reserve</param>
   /// <param name="pts_count">Pointers count to reserve</param>
   /// <returns></returns>
   virtual public  void Reserve(  uint cmd_count,   uint pts_count) {
                                           Efl.Gfx.PathNativeInherit.efl_gfx_path_reserve_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), cmd_count,  pts_count);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Request to update the path object.
   /// One path object may get appending several path calls (such as append_cubic, append_rect, etc) to construct the final path data. Here commit means all path data is prepared and now object could update its own internal status based on the last path information.</summary>
   /// <returns></returns>
   virtual public  void Commit() {
       Efl.Gfx.PathNativeInherit.efl_gfx_path_commit_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Retrieves the layer of its canvas that the given object is part of.
   /// See also <see cref="Efl.Gfx.Stack.SetLayer"/></summary>
   /// <returns>The number of the layer to place the object on. Must be between <see cref="Efl.Gfx.Constants.StackLayerMin"/> and <see cref="Efl.Gfx.Constants.StackLayerMax"/>.</returns>
   virtual public  short GetLayer() {
       var _ret_var = Efl.Gfx.StackNativeInherit.efl_gfx_stack_layer_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Sets the layer of its canvas that the given object will be part of.
   /// If you don&apos;t use this function, you&apos;ll be dealing with an unique layer of objects (the default one). Additional layers are handy when you don&apos;t want a set of objects to interfere with another set with regard to stacking. Two layers are completely disjoint in that matter.
   /// 
   /// This is a low-level function, which you&apos;d be using when something should be always on top, for example.
   /// 
   /// Warning: Don&apos;t change the layer of smart objects&apos; children. Smart objects have a layer of their own, which should contain all their child objects.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.GetLayer"/></summary>
   /// <param name="l">The number of the layer to place the object on. Must be between <see cref="Efl.Gfx.Constants.StackLayerMin"/> and <see cref="Efl.Gfx.Constants.StackLayerMax"/>.</param>
   /// <returns></returns>
   virtual public  void SetLayer(  short l) {
                         Efl.Gfx.StackNativeInherit.efl_gfx_stack_layer_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), l);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Get the Evas object stacked right below <c>obj</c>
   /// This function will traverse layers in its search, if there are objects on layers below the one <c>obj</c> is placed at.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.GetBelow"/></summary>
   /// <returns>The <see cref="Efl.Gfx.Stack"/> object directly below <c>obj</c>, if any, or <c>null</c>, if none.</returns>
   virtual public Efl.Gfx.Stack GetBelow() {
       var _ret_var = Efl.Gfx.StackNativeInherit.efl_gfx_stack_below_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Get the Evas object stacked right above <c>obj</c>
   /// This function will traverse layers in its search, if there are objects on layers above the one <c>obj</c> is placed at.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.GetBelow"/></summary>
   /// <returns>The <see cref="Efl.Gfx.Stack"/> object directly below <c>obj</c>, if any, or <c>null</c>, if none.</returns>
   virtual public Efl.Gfx.Stack GetAbove() {
       var _ret_var = Efl.Gfx.StackNativeInherit.efl_gfx_stack_above_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Stack <c>obj</c> immediately <c>below</c>
   /// Objects, in a given canvas, are stacked in the order they&apos;re added. This means that, if they overlap, the highest ones will cover the lowest ones, in that order. This function is a way to change the stacking order for the objects.
   /// 
   /// Its intended to be used with objects belonging to the same layer in a given canvas, otherwise it will fail (and accomplish nothing).
   /// 
   /// If you have smart objects on your canvas and <c>obj</c> is a member of one of them, then <c>below</c> must also be a member of the same smart object.
   /// 
   /// Similarly, if <c>obj</c> is not a member of a smart object, <c>below</c> must not be either.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.StackBelow"/></summary>
   /// <param name="below">The object below which to stack</param>
   /// <returns></returns>
   virtual public  void StackBelow( Efl.Gfx.Stack below) {
                         Efl.Gfx.StackNativeInherit.efl_gfx_stack_below_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), below);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Raise <c>obj</c> to the top of its layer.
   /// <c>obj</c> will, then, be the highest one in the layer it belongs to. Object on other layers won&apos;t get touched.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.StackAbove"/>, <see cref="Efl.Gfx.Stack.StackBelow"/> and <see cref="Efl.Gfx.Stack.LowerToBottom"/></summary>
   /// <returns></returns>
   virtual public  void RaiseToTop() {
       Efl.Gfx.StackNativeInherit.efl_gfx_stack_raise_to_top_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Stack <c>obj</c> immediately <c>above</c>
   /// Objects, in a given canvas, are stacked in the order they&apos;re added. This means that, if they overlap, the highest ones will cover the lowest ones, in that order. This function is a way to change the stacking order for the objects.
   /// 
   /// Its intended to be used with objects belonging to the same layer in a given canvas, otherwise it will fail (and accomplish nothing).
   /// 
   /// If you have smart objects on your canvas and <c>obj</c> is a member of one of them, then <c>above</c> must also be a member of the same smart object.
   /// 
   /// Similarly, if <c>obj</c> is not a member of a smart object, <c>above</c> must not be either.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.StackBelow"/></summary>
   /// <param name="above">The object above which to stack</param>
   /// <returns></returns>
   virtual public  void StackAbove( Efl.Gfx.Stack above) {
                         Efl.Gfx.StackNativeInherit.efl_gfx_stack_above_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), above);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Lower <c>obj</c> to the bottom of its layer.
   /// <c>obj</c> will, then, be the lowest one in the layer it belongs to. Objects on other layers won&apos;t get touched.
   /// 
   /// See also <see cref="Efl.Gfx.Stack.StackAbove"/>, <see cref="Efl.Gfx.Stack.StackBelow"/> and <see cref="Efl.Gfx.Stack.RaiseToTop"/></summary>
   /// <returns></returns>
   virtual public  void LowerToBottom() {
       Efl.Gfx.StackNativeInherit.efl_gfx_stack_lower_to_bottom_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Gets the transformation matrix used for this node object.
/// 1.14</summary>
/// <value>Transformation matrix.</value>
   public Eina.Matrix3 Transformation {
      get { return GetTransformation(); }
      set { SetTransformation( ref value); }
   }
   /// <summary>Get hex color code of given Evas object. This returns a short lived hex color code string.</summary>
/// <value>the hex color code.</value>
   public  System.String ColorCode {
      get { return GetColorCode(); }
      set { SetColorCode( value); }
   }
   /// <summary>The 2D position of a canvas object.
/// The position is absolute, in pixels, relative to the top-left corner of the window, within its border decorations (application space).</summary>
/// <value>A 2D coordinate in pixel units.</value>
   public Eina.Position2D Position {
      get { return GetPosition(); }
      set { SetPosition( value); }
   }
   /// <summary>The 2D size of a canvas object.</summary>
/// <value>A 2D size in pixel units.</value>
   public Eina.Size2D Size {
      get { return GetSize(); }
      set { SetSize( value); }
   }
   /// <summary>Rectangular geometry that combines both position and size.</summary>
/// <value>The X,Y position and W,H size, in pixels.</value>
   public Eina.Rect Geometry {
      get { return GetGeometry(); }
      set { SetGeometry( value); }
   }
   /// <summary>The visibility of a canvas object.
/// All canvas objects will become visible by default just before render. This means that it is not required to call <see cref="Efl.Gfx.Entity.SetVisible"/> after creating an object unless you want to create it without showing it. Note that this behavior is new since 1.21, and only applies to canvas objects created with the EO API (i.e. not the legacy C-only API). Other types of Gfx objects may or may not be visible by default.
/// 
/// Note that many other parameters can prevent a visible object from actually being &quot;visible&quot; on screen. For instance if its color is fully transparent, or its parent is hidden, or it is clipped out, etc...</summary>
/// <value><c>true</c> if to make the object visible, <c>false</c> otherwise</value>
   public bool Visible {
      get { return GetVisible(); }
      set { SetVisible( value); }
   }
   /// <summary>The scaling factor of an object.
/// This property is an individual scaling factor on the object (Edje or UI widget). This property (or Edje&apos;s global scaling factor, when applicable), will affect this object&apos;s part sizes. If scale is not zero, than the individual scaling will override any global scaling set, for the object obj&apos;s parts. Set it back to zero to get the effects of the global scaling again.
/// 
/// Warning: In Edje, only parts which, at EDC level, had the &quot;scale&quot; property set to 1, will be affected by this function. Check the complete &quot;syntax reference&quot; for EDC files.</summary>
/// <value>The scaling factor (the default value is 0.0, meaning individual scaling is not set)</value>
   public double Scale {
      get { return GetScale(); }
      set { SetScale( value); }
   }
   /// <summary>Retrieves the layer of its canvas that the given object is part of.
/// See also <see cref="Efl.Gfx.Stack.SetLayer"/></summary>
/// <value>The number of the layer to place the object on. Must be between <see cref="Efl.Gfx.Constants.StackLayerMin"/> and <see cref="Efl.Gfx.Constants.StackLayerMax"/>.</value>
   public  short Layer {
      get { return GetLayer(); }
      set { SetLayer( value); }
   }
   /// <summary>Get the Evas object stacked right below <c>obj</c>
/// This function will traverse layers in its search, if there are objects on layers below the one <c>obj</c> is placed at.
/// 
/// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.GetBelow"/></summary>
/// <value>The <see cref="Efl.Gfx.Stack"/> object directly below <c>obj</c>, if any, or <c>null</c>, if none.</value>
   public Efl.Gfx.Stack Below {
      get { return GetBelow(); }
   }
   /// <summary>Get the Evas object stacked right above <c>obj</c>
/// This function will traverse layers in its search, if there are objects on layers above the one <c>obj</c> is placed at.
/// 
/// See also <see cref="Efl.Gfx.Stack.GetLayer"/>, <see cref="Efl.Gfx.Stack.SetLayer"/> and <see cref="Efl.Gfx.Stack.GetBelow"/></summary>
/// <value>The <see cref="Efl.Gfx.Stack"/> object directly below <c>obj</c>, if any, or <c>null</c>, if none.</value>
   public Efl.Gfx.Stack Above {
      get { return GetAbove(); }
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Canvas.Vg.Node.efl_canvas_vg_node_class_get();
   }
}
public class NodeNativeInherit : Efl.ObjectNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Evas);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_canvas_vg_node_transformation_get_static_delegate == null)
      efl_canvas_vg_node_transformation_get_static_delegate = new efl_canvas_vg_node_transformation_get_delegate(transformation_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_vg_node_transformation_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_node_transformation_get_static_delegate)});
      if (efl_canvas_vg_node_transformation_set_static_delegate == null)
      efl_canvas_vg_node_transformation_set_static_delegate = new efl_canvas_vg_node_transformation_set_delegate(transformation_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_vg_node_transformation_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_node_transformation_set_static_delegate)});
      if (efl_canvas_vg_node_origin_get_static_delegate == null)
      efl_canvas_vg_node_origin_get_static_delegate = new efl_canvas_vg_node_origin_get_delegate(origin_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_vg_node_origin_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_node_origin_get_static_delegate)});
      if (efl_canvas_vg_node_origin_set_static_delegate == null)
      efl_canvas_vg_node_origin_set_static_delegate = new efl_canvas_vg_node_origin_set_delegate(origin_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_vg_node_origin_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_node_origin_set_static_delegate)});
      if (efl_canvas_vg_node_mask_set_static_delegate == null)
      efl_canvas_vg_node_mask_set_static_delegate = new efl_canvas_vg_node_mask_set_delegate(mask_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_canvas_vg_node_mask_set"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_node_mask_set_static_delegate)});
      if (efl_duplicate_static_delegate == null)
      efl_duplicate_static_delegate = new efl_duplicate_delegate(duplicate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_duplicate"), func = Marshal.GetFunctionPointerForDelegate(efl_duplicate_static_delegate)});
      if (efl_gfx_color_get_static_delegate == null)
      efl_gfx_color_get_static_delegate = new efl_gfx_color_get_delegate(color_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_get_static_delegate)});
      if (efl_gfx_color_set_static_delegate == null)
      efl_gfx_color_set_static_delegate = new efl_gfx_color_set_delegate(color_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_set_static_delegate)});
      if (efl_gfx_color_code_get_static_delegate == null)
      efl_gfx_color_code_get_static_delegate = new efl_gfx_color_code_get_delegate(color_code_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_code_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_code_get_static_delegate)});
      if (efl_gfx_color_code_set_static_delegate == null)
      efl_gfx_color_code_set_static_delegate = new efl_gfx_color_code_set_delegate(color_code_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_color_code_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_color_code_set_static_delegate)});
      if (efl_gfx_entity_position_get_static_delegate == null)
      efl_gfx_entity_position_get_static_delegate = new efl_gfx_entity_position_get_delegate(position_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_position_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_position_get_static_delegate)});
      if (efl_gfx_entity_position_set_static_delegate == null)
      efl_gfx_entity_position_set_static_delegate = new efl_gfx_entity_position_set_delegate(position_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_position_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_position_set_static_delegate)});
      if (efl_gfx_entity_size_get_static_delegate == null)
      efl_gfx_entity_size_get_static_delegate = new efl_gfx_entity_size_get_delegate(size_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_size_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_size_get_static_delegate)});
      if (efl_gfx_entity_size_set_static_delegate == null)
      efl_gfx_entity_size_set_static_delegate = new efl_gfx_entity_size_set_delegate(size_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_size_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_size_set_static_delegate)});
      if (efl_gfx_entity_geometry_get_static_delegate == null)
      efl_gfx_entity_geometry_get_static_delegate = new efl_gfx_entity_geometry_get_delegate(geometry_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_geometry_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_geometry_get_static_delegate)});
      if (efl_gfx_entity_geometry_set_static_delegate == null)
      efl_gfx_entity_geometry_set_static_delegate = new efl_gfx_entity_geometry_set_delegate(geometry_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_geometry_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_geometry_set_static_delegate)});
      if (efl_gfx_entity_visible_get_static_delegate == null)
      efl_gfx_entity_visible_get_static_delegate = new efl_gfx_entity_visible_get_delegate(visible_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_visible_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_visible_get_static_delegate)});
      if (efl_gfx_entity_visible_set_static_delegate == null)
      efl_gfx_entity_visible_set_static_delegate = new efl_gfx_entity_visible_set_delegate(visible_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_visible_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_visible_set_static_delegate)});
      if (efl_gfx_entity_scale_get_static_delegate == null)
      efl_gfx_entity_scale_get_static_delegate = new efl_gfx_entity_scale_get_delegate(scale_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_scale_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_scale_get_static_delegate)});
      if (efl_gfx_entity_scale_set_static_delegate == null)
      efl_gfx_entity_scale_set_static_delegate = new efl_gfx_entity_scale_set_delegate(scale_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_entity_scale_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_entity_scale_set_static_delegate)});
      if (efl_gfx_path_get_static_delegate == null)
      efl_gfx_path_get_static_delegate = new efl_gfx_path_get_delegate(path_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_get_static_delegate)});
      if (efl_gfx_path_set_static_delegate == null)
      efl_gfx_path_set_static_delegate = new efl_gfx_path_set_delegate(path_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_set_static_delegate)});
      if (efl_gfx_path_length_get_static_delegate == null)
      efl_gfx_path_length_get_static_delegate = new efl_gfx_path_length_get_delegate(length_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_length_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_length_get_static_delegate)});
      if (efl_gfx_path_current_get_static_delegate == null)
      efl_gfx_path_current_get_static_delegate = new efl_gfx_path_current_get_delegate(current_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_current_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_current_get_static_delegate)});
      if (efl_gfx_path_current_ctrl_get_static_delegate == null)
      efl_gfx_path_current_ctrl_get_static_delegate = new efl_gfx_path_current_ctrl_get_delegate(current_ctrl_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_current_ctrl_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_current_ctrl_get_static_delegate)});
      if (efl_gfx_path_copy_from_static_delegate == null)
      efl_gfx_path_copy_from_static_delegate = new efl_gfx_path_copy_from_delegate(copy_from);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_copy_from"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_copy_from_static_delegate)});
      if (efl_gfx_path_bounds_get_static_delegate == null)
      efl_gfx_path_bounds_get_static_delegate = new efl_gfx_path_bounds_get_delegate(bounds_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_bounds_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_bounds_get_static_delegate)});
      if (efl_gfx_path_reset_static_delegate == null)
      efl_gfx_path_reset_static_delegate = new efl_gfx_path_reset_delegate(reset);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_reset"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_reset_static_delegate)});
      if (efl_gfx_path_append_move_to_static_delegate == null)
      efl_gfx_path_append_move_to_static_delegate = new efl_gfx_path_append_move_to_delegate(append_move_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_move_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_move_to_static_delegate)});
      if (efl_gfx_path_append_line_to_static_delegate == null)
      efl_gfx_path_append_line_to_static_delegate = new efl_gfx_path_append_line_to_delegate(append_line_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_line_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_line_to_static_delegate)});
      if (efl_gfx_path_append_quadratic_to_static_delegate == null)
      efl_gfx_path_append_quadratic_to_static_delegate = new efl_gfx_path_append_quadratic_to_delegate(append_quadratic_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_quadratic_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_quadratic_to_static_delegate)});
      if (efl_gfx_path_append_squadratic_to_static_delegate == null)
      efl_gfx_path_append_squadratic_to_static_delegate = new efl_gfx_path_append_squadratic_to_delegate(append_squadratic_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_squadratic_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_squadratic_to_static_delegate)});
      if (efl_gfx_path_append_cubic_to_static_delegate == null)
      efl_gfx_path_append_cubic_to_static_delegate = new efl_gfx_path_append_cubic_to_delegate(append_cubic_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_cubic_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_cubic_to_static_delegate)});
      if (efl_gfx_path_append_scubic_to_static_delegate == null)
      efl_gfx_path_append_scubic_to_static_delegate = new efl_gfx_path_append_scubic_to_delegate(append_scubic_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_scubic_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_scubic_to_static_delegate)});
      if (efl_gfx_path_append_arc_to_static_delegate == null)
      efl_gfx_path_append_arc_to_static_delegate = new efl_gfx_path_append_arc_to_delegate(append_arc_to);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_arc_to"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_arc_to_static_delegate)});
      if (efl_gfx_path_append_arc_static_delegate == null)
      efl_gfx_path_append_arc_static_delegate = new efl_gfx_path_append_arc_delegate(append_arc);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_arc"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_arc_static_delegate)});
      if (efl_gfx_path_append_close_static_delegate == null)
      efl_gfx_path_append_close_static_delegate = new efl_gfx_path_append_close_delegate(append_close);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_close"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_close_static_delegate)});
      if (efl_gfx_path_append_circle_static_delegate == null)
      efl_gfx_path_append_circle_static_delegate = new efl_gfx_path_append_circle_delegate(append_circle);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_circle"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_circle_static_delegate)});
      if (efl_gfx_path_append_rect_static_delegate == null)
      efl_gfx_path_append_rect_static_delegate = new efl_gfx_path_append_rect_delegate(append_rect);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_rect"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_rect_static_delegate)});
      if (efl_gfx_path_append_svg_path_static_delegate == null)
      efl_gfx_path_append_svg_path_static_delegate = new efl_gfx_path_append_svg_path_delegate(append_svg_path);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_append_svg_path"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_append_svg_path_static_delegate)});
      if (efl_gfx_path_interpolate_static_delegate == null)
      efl_gfx_path_interpolate_static_delegate = new efl_gfx_path_interpolate_delegate(interpolate);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_interpolate"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_interpolate_static_delegate)});
      if (efl_gfx_path_equal_commands_static_delegate == null)
      efl_gfx_path_equal_commands_static_delegate = new efl_gfx_path_equal_commands_delegate(equal_commands);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_equal_commands"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_equal_commands_static_delegate)});
      if (efl_gfx_path_reserve_static_delegate == null)
      efl_gfx_path_reserve_static_delegate = new efl_gfx_path_reserve_delegate(reserve);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_reserve"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_reserve_static_delegate)});
      if (efl_gfx_path_commit_static_delegate == null)
      efl_gfx_path_commit_static_delegate = new efl_gfx_path_commit_delegate(commit);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_path_commit"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_path_commit_static_delegate)});
      if (efl_gfx_stack_layer_get_static_delegate == null)
      efl_gfx_stack_layer_get_static_delegate = new efl_gfx_stack_layer_get_delegate(layer_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_layer_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_layer_get_static_delegate)});
      if (efl_gfx_stack_layer_set_static_delegate == null)
      efl_gfx_stack_layer_set_static_delegate = new efl_gfx_stack_layer_set_delegate(layer_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_layer_set"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_layer_set_static_delegate)});
      if (efl_gfx_stack_below_get_static_delegate == null)
      efl_gfx_stack_below_get_static_delegate = new efl_gfx_stack_below_get_delegate(below_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_below_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_below_get_static_delegate)});
      if (efl_gfx_stack_above_get_static_delegate == null)
      efl_gfx_stack_above_get_static_delegate = new efl_gfx_stack_above_get_delegate(above_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_above_get"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_above_get_static_delegate)});
      if (efl_gfx_stack_below_static_delegate == null)
      efl_gfx_stack_below_static_delegate = new efl_gfx_stack_below_delegate(stack_below);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_below"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_below_static_delegate)});
      if (efl_gfx_stack_raise_to_top_static_delegate == null)
      efl_gfx_stack_raise_to_top_static_delegate = new efl_gfx_stack_raise_to_top_delegate(raise_to_top);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_raise_to_top"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_raise_to_top_static_delegate)});
      if (efl_gfx_stack_above_static_delegate == null)
      efl_gfx_stack_above_static_delegate = new efl_gfx_stack_above_delegate(stack_above);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_above"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_above_static_delegate)});
      if (efl_gfx_stack_lower_to_bottom_static_delegate == null)
      efl_gfx_stack_lower_to_bottom_static_delegate = new efl_gfx_stack_lower_to_bottom_delegate(lower_to_bottom);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_gfx_stack_lower_to_bottom"), func = Marshal.GetFunctionPointerForDelegate(efl_gfx_stack_lower_to_bottom_static_delegate)});
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Canvas.Vg.Node.efl_canvas_vg_node_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Canvas.Vg.Node.efl_canvas_vg_node_class_get();
   }


    private delegate  System.IntPtr efl_canvas_vg_node_transformation_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  System.IntPtr efl_canvas_vg_node_transformation_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_canvas_vg_node_transformation_get_api_delegate> efl_canvas_vg_node_transformation_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_node_transformation_get_api_delegate>(_Module, "efl_canvas_vg_node_transformation_get");
    private static  System.IntPtr transformation_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_canvas_vg_node_transformation_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Matrix3 _ret_var = default(Eina.Matrix3);
         try {
            _ret_var = ((Node)wrapper).GetTransformation();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.PrimitiveConversion.ManagedToPointerAlloc(_ret_var);
      } else {
         return efl_canvas_vg_node_transformation_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_canvas_vg_node_transformation_get_delegate efl_canvas_vg_node_transformation_get_static_delegate;


    private delegate  void efl_canvas_vg_node_transformation_set_delegate(System.IntPtr obj, System.IntPtr pd,   ref Eina.Matrix3_StructInternal m);


    public delegate  void efl_canvas_vg_node_transformation_set_api_delegate(System.IntPtr obj,   ref Eina.Matrix3_StructInternal m);
    public static Efl.Eo.FunctionWrapper<efl_canvas_vg_node_transformation_set_api_delegate> efl_canvas_vg_node_transformation_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_node_transformation_set_api_delegate>(_Module, "efl_canvas_vg_node_transformation_set");
    private static  void transformation_set(System.IntPtr obj, System.IntPtr pd,  ref Eina.Matrix3_StructInternal m)
   {
      Eina.Log.Debug("function efl_canvas_vg_node_transformation_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_m = Eina.Matrix3_StructConversion.ToManaged(m);
                     
         try {
            ((Node)wrapper).SetTransformation( ref _in_m);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            m = Eina.Matrix3_StructConversion.ToInternal(_in_m);
            } else {
         efl_canvas_vg_node_transformation_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  ref m);
      }
   }
   private static efl_canvas_vg_node_transformation_set_delegate efl_canvas_vg_node_transformation_set_static_delegate;


    private delegate  void efl_canvas_vg_node_origin_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double x,   out double y);


    public delegate  void efl_canvas_vg_node_origin_get_api_delegate(System.IntPtr obj,   out double x,   out double y);
    public static Efl.Eo.FunctionWrapper<efl_canvas_vg_node_origin_get_api_delegate> efl_canvas_vg_node_origin_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_node_origin_get_api_delegate>(_Module, "efl_canvas_vg_node_origin_get");
    private static  void origin_get(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y)
   {
      Eina.Log.Debug("function efl_canvas_vg_node_origin_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default(double);      y = default(double);                     
         try {
            ((Node)wrapper).GetOrigin( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_canvas_vg_node_origin_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static efl_canvas_vg_node_origin_get_delegate efl_canvas_vg_node_origin_get_static_delegate;


    private delegate  void efl_canvas_vg_node_origin_set_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y);


    public delegate  void efl_canvas_vg_node_origin_set_api_delegate(System.IntPtr obj,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<efl_canvas_vg_node_origin_set_api_delegate> efl_canvas_vg_node_origin_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_node_origin_set_api_delegate>(_Module, "efl_canvas_vg_node_origin_set");
    private static  void origin_set(System.IntPtr obj, System.IntPtr pd,  double x,  double y)
   {
      Eina.Log.Debug("function efl_canvas_vg_node_origin_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).SetOrigin( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_canvas_vg_node_origin_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static efl_canvas_vg_node_origin_set_delegate efl_canvas_vg_node_origin_set_static_delegate;


    private delegate  void efl_canvas_vg_node_mask_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Vg.Node, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Vg.Node mask,    int op);


    public delegate  void efl_canvas_vg_node_mask_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Vg.Node, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Vg.Node mask,    int op);
    public static Efl.Eo.FunctionWrapper<efl_canvas_vg_node_mask_set_api_delegate> efl_canvas_vg_node_mask_set_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_node_mask_set_api_delegate>(_Module, "efl_canvas_vg_node_mask_set");
    private static  void mask_set(System.IntPtr obj, System.IntPtr pd,  Efl.Canvas.Vg.Node mask,   int op)
   {
      Eina.Log.Debug("function efl_canvas_vg_node_mask_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).SetMask( mask,  op);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_canvas_vg_node_mask_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  mask,  op);
      }
   }
   private static efl_canvas_vg_node_mask_set_delegate efl_canvas_vg_node_mask_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.DuplicateConcrete, Efl.Eo.OwnTag>))] private delegate Efl.Duplicate efl_duplicate_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.DuplicateConcrete, Efl.Eo.OwnTag>))] public delegate Efl.Duplicate efl_duplicate_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_duplicate_api_delegate> efl_duplicate_ptr = new Efl.Eo.FunctionWrapper<efl_duplicate_api_delegate>(_Module, "efl_duplicate");
    private static Efl.Duplicate duplicate(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_duplicate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Duplicate _ret_var = default(Efl.Duplicate);
         try {
            _ret_var = ((Node)wrapper).DoDuplicate();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_duplicate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_duplicate_delegate efl_duplicate_static_delegate;


    private delegate  void efl_gfx_color_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int r,   out  int g,   out  int b,   out  int a);


    public delegate  void efl_gfx_color_get_api_delegate(System.IntPtr obj,   out  int r,   out  int g,   out  int b,   out  int a);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_get_api_delegate> efl_gfx_color_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_get_api_delegate>(_Module, "efl_gfx_color_get");
    private static  void color_get(System.IntPtr obj, System.IntPtr pd,  out  int r,  out  int g,  out  int b,  out  int a)
   {
      Eina.Log.Debug("function efl_gfx_color_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       r = default( int);      g = default( int);      b = default( int);      a = default( int);                                 
         try {
            ((Node)wrapper).GetColor( out r,  out g,  out b,  out a);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_color_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out r,  out g,  out b,  out a);
      }
   }
   private static efl_gfx_color_get_delegate efl_gfx_color_get_static_delegate;


    private delegate  void efl_gfx_color_set_delegate(System.IntPtr obj, System.IntPtr pd,    int r,    int g,    int b,    int a);


    public delegate  void efl_gfx_color_set_api_delegate(System.IntPtr obj,    int r,    int g,    int b,    int a);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_set_api_delegate> efl_gfx_color_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_set_api_delegate>(_Module, "efl_gfx_color_set");
    private static  void color_set(System.IntPtr obj, System.IntPtr pd,   int r,   int g,   int b,   int a)
   {
      Eina.Log.Debug("function efl_gfx_color_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((Node)wrapper).SetColor( r,  g,  b,  a);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_color_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  r,  g,  b,  a);
      }
   }
   private static efl_gfx_color_set_delegate efl_gfx_color_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_gfx_color_code_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_gfx_color_code_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_code_get_api_delegate> efl_gfx_color_code_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_code_get_api_delegate>(_Module, "efl_gfx_color_code_get");
    private static  System.String color_code_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_color_code_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((Node)wrapper).GetColorCode();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_color_code_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_color_code_get_delegate efl_gfx_color_code_get_static_delegate;


    private delegate  void efl_gfx_color_code_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String colorcode);


    public delegate  void efl_gfx_color_code_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String colorcode);
    public static Efl.Eo.FunctionWrapper<efl_gfx_color_code_set_api_delegate> efl_gfx_color_code_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_color_code_set_api_delegate>(_Module, "efl_gfx_color_code_set");
    private static  void color_code_set(System.IntPtr obj, System.IntPtr pd,   System.String colorcode)
   {
      Eina.Log.Debug("function efl_gfx_color_code_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).SetColorCode( colorcode);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_color_code_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  colorcode);
      }
   }
   private static efl_gfx_color_code_set_delegate efl_gfx_color_code_set_static_delegate;


    private delegate Eina.Position2D_StructInternal efl_gfx_entity_position_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Position2D_StructInternal efl_gfx_entity_position_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_position_get_api_delegate> efl_gfx_entity_position_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_position_get_api_delegate>(_Module, "efl_gfx_entity_position_get");
    private static Eina.Position2D_StructInternal position_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_entity_position_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Position2D _ret_var = default(Eina.Position2D);
         try {
            _ret_var = ((Node)wrapper).GetPosition();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Position2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_gfx_entity_position_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_entity_position_get_delegate efl_gfx_entity_position_get_static_delegate;


    private delegate  void efl_gfx_entity_position_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Position2D_StructInternal pos);


    public delegate  void efl_gfx_entity_position_set_api_delegate(System.IntPtr obj,   Eina.Position2D_StructInternal pos);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_position_set_api_delegate> efl_gfx_entity_position_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_position_set_api_delegate>(_Module, "efl_gfx_entity_position_set");
    private static  void position_set(System.IntPtr obj, System.IntPtr pd,  Eina.Position2D_StructInternal pos)
   {
      Eina.Log.Debug("function efl_gfx_entity_position_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_pos = Eina.Position2D_StructConversion.ToManaged(pos);
                     
         try {
            ((Node)wrapper).SetPosition( _in_pos);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_entity_position_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pos);
      }
   }
   private static efl_gfx_entity_position_set_delegate efl_gfx_entity_position_set_static_delegate;


    private delegate Eina.Size2D_StructInternal efl_gfx_entity_size_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Size2D_StructInternal efl_gfx_entity_size_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_size_get_api_delegate> efl_gfx_entity_size_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_size_get_api_delegate>(_Module, "efl_gfx_entity_size_get");
    private static Eina.Size2D_StructInternal size_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_entity_size_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Size2D _ret_var = default(Eina.Size2D);
         try {
            _ret_var = ((Node)wrapper).GetSize();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Size2D_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_gfx_entity_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_entity_size_get_delegate efl_gfx_entity_size_get_static_delegate;


    private delegate  void efl_gfx_entity_size_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Size2D_StructInternal size);


    public delegate  void efl_gfx_entity_size_set_api_delegate(System.IntPtr obj,   Eina.Size2D_StructInternal size);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_size_set_api_delegate> efl_gfx_entity_size_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_size_set_api_delegate>(_Module, "efl_gfx_entity_size_set");
    private static  void size_set(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D_StructInternal size)
   {
      Eina.Log.Debug("function efl_gfx_entity_size_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_size = Eina.Size2D_StructConversion.ToManaged(size);
                     
         try {
            ((Node)wrapper).SetSize( _in_size);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_entity_size_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  size);
      }
   }
   private static efl_gfx_entity_size_set_delegate efl_gfx_entity_size_set_static_delegate;


    private delegate Eina.Rect_StructInternal efl_gfx_entity_geometry_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Eina.Rect_StructInternal efl_gfx_entity_geometry_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_geometry_get_api_delegate> efl_gfx_entity_geometry_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_geometry_get_api_delegate>(_Module, "efl_gfx_entity_geometry_get");
    private static Eina.Rect_StructInternal geometry_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_entity_geometry_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Rect _ret_var = default(Eina.Rect);
         try {
            _ret_var = ((Node)wrapper).GetGeometry();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Eina.Rect_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_gfx_entity_geometry_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_entity_geometry_get_delegate efl_gfx_entity_geometry_get_static_delegate;


    private delegate  void efl_gfx_entity_geometry_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect_StructInternal rect);


    public delegate  void efl_gfx_entity_geometry_set_api_delegate(System.IntPtr obj,   Eina.Rect_StructInternal rect);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_geometry_set_api_delegate> efl_gfx_entity_geometry_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_geometry_set_api_delegate>(_Module, "efl_gfx_entity_geometry_set");
    private static  void geometry_set(System.IntPtr obj, System.IntPtr pd,  Eina.Rect_StructInternal rect)
   {
      Eina.Log.Debug("function efl_gfx_entity_geometry_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_rect = Eina.Rect_StructConversion.ToManaged(rect);
                     
         try {
            ((Node)wrapper).SetGeometry( _in_rect);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_entity_geometry_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  rect);
      }
   }
   private static efl_gfx_entity_geometry_set_delegate efl_gfx_entity_geometry_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_gfx_entity_visible_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_gfx_entity_visible_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_visible_get_api_delegate> efl_gfx_entity_visible_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_visible_get_api_delegate>(_Module, "efl_gfx_entity_visible_get");
    private static bool visible_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_entity_visible_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((Node)wrapper).GetVisible();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_entity_visible_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_entity_visible_get_delegate efl_gfx_entity_visible_get_static_delegate;


    private delegate  void efl_gfx_entity_visible_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool v);


    public delegate  void efl_gfx_entity_visible_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool v);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_visible_set_api_delegate> efl_gfx_entity_visible_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_visible_set_api_delegate>(_Module, "efl_gfx_entity_visible_set");
    private static  void visible_set(System.IntPtr obj, System.IntPtr pd,  bool v)
   {
      Eina.Log.Debug("function efl_gfx_entity_visible_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).SetVisible( v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_entity_visible_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  v);
      }
   }
   private static efl_gfx_entity_visible_set_delegate efl_gfx_entity_visible_set_static_delegate;


    private delegate double efl_gfx_entity_scale_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate double efl_gfx_entity_scale_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_scale_get_api_delegate> efl_gfx_entity_scale_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_scale_get_api_delegate>(_Module, "efl_gfx_entity_scale_get");
    private static double scale_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_entity_scale_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  double _ret_var = default(double);
         try {
            _ret_var = ((Node)wrapper).GetScale();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_entity_scale_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_entity_scale_get_delegate efl_gfx_entity_scale_get_static_delegate;


    private delegate  void efl_gfx_entity_scale_set_delegate(System.IntPtr obj, System.IntPtr pd,   double scale);


    public delegate  void efl_gfx_entity_scale_set_api_delegate(System.IntPtr obj,   double scale);
    public static Efl.Eo.FunctionWrapper<efl_gfx_entity_scale_set_api_delegate> efl_gfx_entity_scale_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_entity_scale_set_api_delegate>(_Module, "efl_gfx_entity_scale_set");
    private static  void scale_set(System.IntPtr obj, System.IntPtr pd,  double scale)
   {
      Eina.Log.Debug("function efl_gfx_entity_scale_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).SetScale( scale);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_entity_scale_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scale);
      }
   }
   private static efl_gfx_entity_scale_set_delegate efl_gfx_entity_scale_set_static_delegate;


    private delegate  void efl_gfx_path_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  System.IntPtr op,   out  System.IntPtr points);


    public delegate  void efl_gfx_path_get_api_delegate(System.IntPtr obj,   out  System.IntPtr op,   out  System.IntPtr points);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_get_api_delegate> efl_gfx_path_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_get_api_delegate>(_Module, "efl_gfx_path_get");
    private static  void path_get(System.IntPtr obj, System.IntPtr pd,  out  System.IntPtr op,  out  System.IntPtr points)
   {
      Eina.Log.Debug("function efl_gfx_path_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           Efl.Gfx.PathCommandType _out_op = default(Efl.Gfx.PathCommandType);
      double _out_points = default(double);
                     
         try {
            ((Node)wrapper).GetPath( out _out_op,  out _out_points);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      op = Eina.PrimitiveConversion.ManagedToPointerAlloc(_out_op);
      points = Eina.PrimitiveConversion.ManagedToPointerAlloc(_out_points);
                        } else {
         efl_gfx_path_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out op,  out points);
      }
   }
   private static efl_gfx_path_get_delegate efl_gfx_path_get_static_delegate;


    private delegate  void efl_gfx_path_set_delegate(System.IntPtr obj, System.IntPtr pd,    System.IntPtr op,    System.IntPtr points);


    public delegate  void efl_gfx_path_set_api_delegate(System.IntPtr obj,    System.IntPtr op,    System.IntPtr points);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_set_api_delegate> efl_gfx_path_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_set_api_delegate>(_Module, "efl_gfx_path_set");
    private static  void path_set(System.IntPtr obj, System.IntPtr pd,   System.IntPtr op,   System.IntPtr points)
   {
      Eina.Log.Debug("function efl_gfx_path_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_op = Eina.PrimitiveConversion.PointerToManaged<Efl.Gfx.PathCommandType>(op);
      var _in_points = Eina.PrimitiveConversion.PointerToManaged<double>(points);
                                 
         try {
            ((Node)wrapper).SetPath( _in_op,  _in_points);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  op,  points);
      }
   }
   private static efl_gfx_path_set_delegate efl_gfx_path_set_static_delegate;


    private delegate  void efl_gfx_path_length_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  uint commands,   out  uint points);


    public delegate  void efl_gfx_path_length_get_api_delegate(System.IntPtr obj,   out  uint commands,   out  uint points);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_length_get_api_delegate> efl_gfx_path_length_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_length_get_api_delegate>(_Module, "efl_gfx_path_length_get");
    private static  void length_get(System.IntPtr obj, System.IntPtr pd,  out  uint commands,  out  uint points)
   {
      Eina.Log.Debug("function efl_gfx_path_length_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           commands = default( uint);      points = default( uint);                     
         try {
            ((Node)wrapper).GetLength( out commands,  out points);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_length_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out commands,  out points);
      }
   }
   private static efl_gfx_path_length_get_delegate efl_gfx_path_length_get_static_delegate;


    private delegate  void efl_gfx_path_current_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double x,   out double y);


    public delegate  void efl_gfx_path_current_get_api_delegate(System.IntPtr obj,   out double x,   out double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_current_get_api_delegate> efl_gfx_path_current_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_current_get_api_delegate>(_Module, "efl_gfx_path_current_get");
    private static  void current_get(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y)
   {
      Eina.Log.Debug("function efl_gfx_path_current_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default(double);      y = default(double);                     
         try {
            ((Node)wrapper).GetCurrent( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_current_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static efl_gfx_path_current_get_delegate efl_gfx_path_current_get_static_delegate;


    private delegate  void efl_gfx_path_current_ctrl_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double x,   out double y);


    public delegate  void efl_gfx_path_current_ctrl_get_api_delegate(System.IntPtr obj,   out double x,   out double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_current_ctrl_get_api_delegate> efl_gfx_path_current_ctrl_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_current_ctrl_get_api_delegate>(_Module, "efl_gfx_path_current_ctrl_get");
    private static  void current_ctrl_get(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y)
   {
      Eina.Log.Debug("function efl_gfx_path_current_ctrl_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default(double);      y = default(double);                     
         try {
            ((Node)wrapper).GetCurrentCtrl( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_current_ctrl_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static efl_gfx_path_current_ctrl_get_delegate efl_gfx_path_current_ctrl_get_static_delegate;


    private delegate  void efl_gfx_path_copy_from_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object dup_from);


    public delegate  void efl_gfx_path_copy_from_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object dup_from);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_copy_from_api_delegate> efl_gfx_path_copy_from_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_copy_from_api_delegate>(_Module, "efl_gfx_path_copy_from");
    private static  void copy_from(System.IntPtr obj, System.IntPtr pd,  Efl.Object dup_from)
   {
      Eina.Log.Debug("function efl_gfx_path_copy_from was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).CopyFrom( dup_from);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_path_copy_from_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  dup_from);
      }
   }
   private static efl_gfx_path_copy_from_delegate efl_gfx_path_copy_from_static_delegate;


    private delegate  void efl_gfx_path_bounds_get_delegate(System.IntPtr obj, System.IntPtr pd,   out Eina.Rect_StructInternal r);


    public delegate  void efl_gfx_path_bounds_get_api_delegate(System.IntPtr obj,   out Eina.Rect_StructInternal r);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_bounds_get_api_delegate> efl_gfx_path_bounds_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_bounds_get_api_delegate>(_Module, "efl_gfx_path_bounds_get");
    private static  void bounds_get(System.IntPtr obj, System.IntPtr pd,  out Eina.Rect_StructInternal r)
   {
      Eina.Log.Debug("function efl_gfx_path_bounds_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                     Eina.Rect _out_r = default(Eina.Rect);
               
         try {
            ((Node)wrapper).GetBounds( out _out_r);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      r = Eina.Rect_StructConversion.ToInternal(_out_r);
                  } else {
         efl_gfx_path_bounds_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out r);
      }
   }
   private static efl_gfx_path_bounds_get_delegate efl_gfx_path_bounds_get_static_delegate;


    private delegate  void efl_gfx_path_reset_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_gfx_path_reset_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_reset_api_delegate> efl_gfx_path_reset_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_reset_api_delegate>(_Module, "efl_gfx_path_reset");
    private static  void reset(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_path_reset was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Node)wrapper).Reset();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_gfx_path_reset_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_path_reset_delegate efl_gfx_path_reset_static_delegate;


    private delegate  void efl_gfx_path_append_move_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y);


    public delegate  void efl_gfx_path_append_move_to_api_delegate(System.IntPtr obj,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_move_to_api_delegate> efl_gfx_path_append_move_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_move_to_api_delegate>(_Module, "efl_gfx_path_append_move_to");
    private static  void append_move_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_move_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).AppendMoveTo( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_append_move_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static efl_gfx_path_append_move_to_delegate efl_gfx_path_append_move_to_static_delegate;


    private delegate  void efl_gfx_path_append_line_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y);


    public delegate  void efl_gfx_path_append_line_to_api_delegate(System.IntPtr obj,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_line_to_api_delegate> efl_gfx_path_append_line_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_line_to_api_delegate>(_Module, "efl_gfx_path_append_line_to");
    private static  void append_line_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_line_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).AppendLineTo( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_append_line_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static efl_gfx_path_append_line_to_delegate efl_gfx_path_append_line_to_static_delegate;


    private delegate  void efl_gfx_path_append_quadratic_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double ctrl_x,   double ctrl_y);


    public delegate  void efl_gfx_path_append_quadratic_to_api_delegate(System.IntPtr obj,   double x,   double y,   double ctrl_x,   double ctrl_y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_quadratic_to_api_delegate> efl_gfx_path_append_quadratic_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_quadratic_to_api_delegate>(_Module, "efl_gfx_path_append_quadratic_to");
    private static  void append_quadratic_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double ctrl_x,  double ctrl_y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_quadratic_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((Node)wrapper).AppendQuadraticTo( x,  y,  ctrl_x,  ctrl_y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_path_append_quadratic_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  ctrl_x,  ctrl_y);
      }
   }
   private static efl_gfx_path_append_quadratic_to_delegate efl_gfx_path_append_quadratic_to_static_delegate;


    private delegate  void efl_gfx_path_append_squadratic_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y);


    public delegate  void efl_gfx_path_append_squadratic_to_api_delegate(System.IntPtr obj,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_squadratic_to_api_delegate> efl_gfx_path_append_squadratic_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_squadratic_to_api_delegate>(_Module, "efl_gfx_path_append_squadratic_to");
    private static  void append_squadratic_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_squadratic_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).AppendSquadraticTo( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_append_squadratic_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static efl_gfx_path_append_squadratic_to_delegate efl_gfx_path_append_squadratic_to_static_delegate;


    private delegate  void efl_gfx_path_append_cubic_to_delegate(System.IntPtr obj, System.IntPtr pd,   double ctrl_x0,   double ctrl_y0,   double ctrl_x1,   double ctrl_y1,   double x,   double y);


    public delegate  void efl_gfx_path_append_cubic_to_api_delegate(System.IntPtr obj,   double ctrl_x0,   double ctrl_y0,   double ctrl_x1,   double ctrl_y1,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_cubic_to_api_delegate> efl_gfx_path_append_cubic_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_cubic_to_api_delegate>(_Module, "efl_gfx_path_append_cubic_to");
    private static  void append_cubic_to(System.IntPtr obj, System.IntPtr pd,  double ctrl_x0,  double ctrl_y0,  double ctrl_x1,  double ctrl_y1,  double x,  double y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_cubic_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                                              
         try {
            ((Node)wrapper).AppendCubicTo( ctrl_x0,  ctrl_y0,  ctrl_x1,  ctrl_y1,  x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                                    } else {
         efl_gfx_path_append_cubic_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  ctrl_x0,  ctrl_y0,  ctrl_x1,  ctrl_y1,  x,  y);
      }
   }
   private static efl_gfx_path_append_cubic_to_delegate efl_gfx_path_append_cubic_to_static_delegate;


    private delegate  void efl_gfx_path_append_scubic_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double ctrl_x,   double ctrl_y);


    public delegate  void efl_gfx_path_append_scubic_to_api_delegate(System.IntPtr obj,   double x,   double y,   double ctrl_x,   double ctrl_y);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_scubic_to_api_delegate> efl_gfx_path_append_scubic_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_scubic_to_api_delegate>(_Module, "efl_gfx_path_append_scubic_to");
    private static  void append_scubic_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double ctrl_x,  double ctrl_y)
   {
      Eina.Log.Debug("function efl_gfx_path_append_scubic_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((Node)wrapper).AppendScubicTo( x,  y,  ctrl_x,  ctrl_y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         efl_gfx_path_append_scubic_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  ctrl_x,  ctrl_y);
      }
   }
   private static efl_gfx_path_append_scubic_to_delegate efl_gfx_path_append_scubic_to_static_delegate;


    private delegate  void efl_gfx_path_append_arc_to_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double rx,   double ry,   double angle,  [MarshalAs(UnmanagedType.U1)]  bool large_arc,  [MarshalAs(UnmanagedType.U1)]  bool sweep);


    public delegate  void efl_gfx_path_append_arc_to_api_delegate(System.IntPtr obj,   double x,   double y,   double rx,   double ry,   double angle,  [MarshalAs(UnmanagedType.U1)]  bool large_arc,  [MarshalAs(UnmanagedType.U1)]  bool sweep);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_arc_to_api_delegate> efl_gfx_path_append_arc_to_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_arc_to_api_delegate>(_Module, "efl_gfx_path_append_arc_to");
    private static  void append_arc_to(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double rx,  double ry,  double angle,  bool large_arc,  bool sweep)
   {
      Eina.Log.Debug("function efl_gfx_path_append_arc_to was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                                                                
         try {
            ((Node)wrapper).AppendArcTo( x,  y,  rx,  ry,  angle,  large_arc,  sweep);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                                                } else {
         efl_gfx_path_append_arc_to_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  rx,  ry,  angle,  large_arc,  sweep);
      }
   }
   private static efl_gfx_path_append_arc_to_delegate efl_gfx_path_append_arc_to_static_delegate;


    private delegate  void efl_gfx_path_append_arc_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double w,   double h,   double start_angle,   double sweep_length);


    public delegate  void efl_gfx_path_append_arc_api_delegate(System.IntPtr obj,   double x,   double y,   double w,   double h,   double start_angle,   double sweep_length);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_arc_api_delegate> efl_gfx_path_append_arc_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_arc_api_delegate>(_Module, "efl_gfx_path_append_arc");
    private static  void append_arc(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double w,  double h,  double start_angle,  double sweep_length)
   {
      Eina.Log.Debug("function efl_gfx_path_append_arc was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                                              
         try {
            ((Node)wrapper).AppendArc( x,  y,  w,  h,  start_angle,  sweep_length);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                                    } else {
         efl_gfx_path_append_arc_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  w,  h,  start_angle,  sweep_length);
      }
   }
   private static efl_gfx_path_append_arc_delegate efl_gfx_path_append_arc_static_delegate;


    private delegate  void efl_gfx_path_append_close_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_gfx_path_append_close_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_close_api_delegate> efl_gfx_path_append_close_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_close_api_delegate>(_Module, "efl_gfx_path_append_close");
    private static  void append_close(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_path_append_close was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Node)wrapper).CloseAppend();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_gfx_path_append_close_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_path_append_close_delegate efl_gfx_path_append_close_static_delegate;


    private delegate  void efl_gfx_path_append_circle_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double radius);


    public delegate  void efl_gfx_path_append_circle_api_delegate(System.IntPtr obj,   double x,   double y,   double radius);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_circle_api_delegate> efl_gfx_path_append_circle_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_circle_api_delegate>(_Module, "efl_gfx_path_append_circle");
    private static  void append_circle(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double radius)
   {
      Eina.Log.Debug("function efl_gfx_path_append_circle was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        
         try {
            ((Node)wrapper).AppendCircle( x,  y,  radius);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                } else {
         efl_gfx_path_append_circle_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  radius);
      }
   }
   private static efl_gfx_path_append_circle_delegate efl_gfx_path_append_circle_static_delegate;


    private delegate  void efl_gfx_path_append_rect_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y,   double w,   double h,   double rx,   double ry);


    public delegate  void efl_gfx_path_append_rect_api_delegate(System.IntPtr obj,   double x,   double y,   double w,   double h,   double rx,   double ry);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_rect_api_delegate> efl_gfx_path_append_rect_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_rect_api_delegate>(_Module, "efl_gfx_path_append_rect");
    private static  void append_rect(System.IntPtr obj, System.IntPtr pd,  double x,  double y,  double w,  double h,  double rx,  double ry)
   {
      Eina.Log.Debug("function efl_gfx_path_append_rect was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                                                              
         try {
            ((Node)wrapper).AppendRect( x,  y,  w,  h,  rx,  ry);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                                                    } else {
         efl_gfx_path_append_rect_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  w,  h,  rx,  ry);
      }
   }
   private static efl_gfx_path_append_rect_delegate efl_gfx_path_append_rect_static_delegate;


    private delegate  void efl_gfx_path_append_svg_path_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String svg_path_data);


    public delegate  void efl_gfx_path_append_svg_path_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String svg_path_data);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_append_svg_path_api_delegate> efl_gfx_path_append_svg_path_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_append_svg_path_api_delegate>(_Module, "efl_gfx_path_append_svg_path");
    private static  void append_svg_path(System.IntPtr obj, System.IntPtr pd,   System.String svg_path_data)
   {
      Eina.Log.Debug("function efl_gfx_path_append_svg_path was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).AppendSvgPath( svg_path_data);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_path_append_svg_path_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  svg_path_data);
      }
   }
   private static efl_gfx_path_append_svg_path_delegate efl_gfx_path_append_svg_path_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_gfx_path_interpolate_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object from, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object to,   double pos_map);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_gfx_path_interpolate_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object from, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object to,   double pos_map);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_interpolate_api_delegate> efl_gfx_path_interpolate_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_interpolate_api_delegate>(_Module, "efl_gfx_path_interpolate");
    private static bool interpolate(System.IntPtr obj, System.IntPtr pd,  Efl.Object from,  Efl.Object to,  double pos_map)
   {
      Eina.Log.Debug("function efl_gfx_path_interpolate was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        bool _ret_var = default(bool);
         try {
            _ret_var = ((Node)wrapper).Interpolate( from,  to,  pos_map);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_gfx_path_interpolate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  from,  to,  pos_map);
      }
   }
   private static efl_gfx_path_interpolate_delegate efl_gfx_path_interpolate_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_gfx_path_equal_commands_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object with);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_gfx_path_equal_commands_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]  Efl.Object with);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_equal_commands_api_delegate> efl_gfx_path_equal_commands_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_equal_commands_api_delegate>(_Module, "efl_gfx_path_equal_commands");
    private static bool equal_commands(System.IntPtr obj, System.IntPtr pd,  Efl.Object with)
   {
      Eina.Log.Debug("function efl_gfx_path_equal_commands was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((Node)wrapper).EqualCommands( with);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_gfx_path_equal_commands_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  with);
      }
   }
   private static efl_gfx_path_equal_commands_delegate efl_gfx_path_equal_commands_static_delegate;


    private delegate  void efl_gfx_path_reserve_delegate(System.IntPtr obj, System.IntPtr pd,    uint cmd_count,    uint pts_count);


    public delegate  void efl_gfx_path_reserve_api_delegate(System.IntPtr obj,    uint cmd_count,    uint pts_count);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_reserve_api_delegate> efl_gfx_path_reserve_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_reserve_api_delegate>(_Module, "efl_gfx_path_reserve");
    private static  void reserve(System.IntPtr obj, System.IntPtr pd,   uint cmd_count,   uint pts_count)
   {
      Eina.Log.Debug("function efl_gfx_path_reserve was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((Node)wrapper).Reserve( cmd_count,  pts_count);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_gfx_path_reserve_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  cmd_count,  pts_count);
      }
   }
   private static efl_gfx_path_reserve_delegate efl_gfx_path_reserve_static_delegate;


    private delegate  void efl_gfx_path_commit_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_gfx_path_commit_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_path_commit_api_delegate> efl_gfx_path_commit_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_path_commit_api_delegate>(_Module, "efl_gfx_path_commit");
    private static  void commit(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_path_commit was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Node)wrapper).Commit();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_gfx_path_commit_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_path_commit_delegate efl_gfx_path_commit_static_delegate;


    private delegate  short efl_gfx_stack_layer_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  short efl_gfx_stack_layer_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_layer_get_api_delegate> efl_gfx_stack_layer_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_layer_get_api_delegate>(_Module, "efl_gfx_stack_layer_get");
    private static  short layer_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_stack_layer_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   short _ret_var = default( short);
         try {
            _ret_var = ((Node)wrapper).GetLayer();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_stack_layer_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_stack_layer_get_delegate efl_gfx_stack_layer_get_static_delegate;


    private delegate  void efl_gfx_stack_layer_set_delegate(System.IntPtr obj, System.IntPtr pd,    short l);


    public delegate  void efl_gfx_stack_layer_set_api_delegate(System.IntPtr obj,    short l);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_layer_set_api_delegate> efl_gfx_stack_layer_set_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_layer_set_api_delegate>(_Module, "efl_gfx_stack_layer_set");
    private static  void layer_set(System.IntPtr obj, System.IntPtr pd,   short l)
   {
      Eina.Log.Debug("function efl_gfx_stack_layer_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).SetLayer( l);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_stack_layer_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  l);
      }
   }
   private static efl_gfx_stack_layer_set_delegate efl_gfx_stack_layer_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Stack efl_gfx_stack_below_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Stack efl_gfx_stack_below_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_below_get_api_delegate> efl_gfx_stack_below_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_below_get_api_delegate>(_Module, "efl_gfx_stack_below_get");
    private static Efl.Gfx.Stack below_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_stack_below_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Gfx.Stack _ret_var = default(Efl.Gfx.Stack);
         try {
            _ret_var = ((Node)wrapper).GetBelow();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_stack_below_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_stack_below_get_delegate efl_gfx_stack_below_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Gfx.Stack efl_gfx_stack_above_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Gfx.Stack efl_gfx_stack_above_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_above_get_api_delegate> efl_gfx_stack_above_get_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_above_get_api_delegate>(_Module, "efl_gfx_stack_above_get");
    private static Efl.Gfx.Stack above_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_stack_above_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Gfx.Stack _ret_var = default(Efl.Gfx.Stack);
         try {
            _ret_var = ((Node)wrapper).GetAbove();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_gfx_stack_above_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_stack_above_get_delegate efl_gfx_stack_above_get_static_delegate;


    private delegate  void efl_gfx_stack_below_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Stack below);


    public delegate  void efl_gfx_stack_below_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Stack below);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_below_api_delegate> efl_gfx_stack_below_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_below_api_delegate>(_Module, "efl_gfx_stack_below");
    private static  void stack_below(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.Stack below)
   {
      Eina.Log.Debug("function efl_gfx_stack_below was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).StackBelow( below);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_stack_below_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  below);
      }
   }
   private static efl_gfx_stack_below_delegate efl_gfx_stack_below_static_delegate;


    private delegate  void efl_gfx_stack_raise_to_top_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_gfx_stack_raise_to_top_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_raise_to_top_api_delegate> efl_gfx_stack_raise_to_top_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_raise_to_top_api_delegate>(_Module, "efl_gfx_stack_raise_to_top");
    private static  void raise_to_top(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_stack_raise_to_top was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Node)wrapper).RaiseToTop();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_gfx_stack_raise_to_top_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_stack_raise_to_top_delegate efl_gfx_stack_raise_to_top_static_delegate;


    private delegate  void efl_gfx_stack_above_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Stack above);


    public delegate  void efl_gfx_stack_above_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Gfx.StackConcrete, Efl.Eo.NonOwnTag>))]  Efl.Gfx.Stack above);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_above_api_delegate> efl_gfx_stack_above_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_above_api_delegate>(_Module, "efl_gfx_stack_above");
    private static  void stack_above(System.IntPtr obj, System.IntPtr pd,  Efl.Gfx.Stack above)
   {
      Eina.Log.Debug("function efl_gfx_stack_above was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((Node)wrapper).StackAbove( above);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_gfx_stack_above_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  above);
      }
   }
   private static efl_gfx_stack_above_delegate efl_gfx_stack_above_static_delegate;


    private delegate  void efl_gfx_stack_lower_to_bottom_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_gfx_stack_lower_to_bottom_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_gfx_stack_lower_to_bottom_api_delegate> efl_gfx_stack_lower_to_bottom_ptr = new Efl.Eo.FunctionWrapper<efl_gfx_stack_lower_to_bottom_api_delegate>(_Module, "efl_gfx_stack_lower_to_bottom");
    private static  void lower_to_bottom(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_gfx_stack_lower_to_bottom was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((Node)wrapper).LowerToBottom();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_gfx_stack_lower_to_bottom_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_gfx_stack_lower_to_bottom_delegate efl_gfx_stack_lower_to_bottom_static_delegate;
}
} } } 
