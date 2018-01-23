﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.AI.NavMeshBuildSource
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
  /// <summary>
  ///   <para>The input to the NavMesh builder is a list of NavMesh build sources.</para>
  /// </summary>
  [UsedByNativeCode]
  public struct NavMeshBuildSource
  {
    private Matrix4x4 m_Transform;
    private Vector3 m_Size;
    private NavMeshBuildSourceShape m_Shape;
    private int m_Area;
    private int m_InstanceID;
    private int m_ComponentID;

    /// <summary>
    ///   <para>Describes the local to world transformation matrix of the build source. That is, position and orientation and scale of the shape.</para>
    /// </summary>
    public Matrix4x4 transform
    {
      get
      {
        return this.m_Transform;
      }
      set
      {
        this.m_Transform = value;
      }
    }

    /// <summary>
    ///   <para>Describes the dimensions of the shape.</para>
    /// </summary>
    public Vector3 size
    {
      get
      {
        return this.m_Size;
      }
      set
      {
        this.m_Size = value;
      }
    }

    /// <summary>
    ///   <para>The type of the shape this source describes. See Also: NavMeshBuildSourceShape.</para>
    /// </summary>
    public NavMeshBuildSourceShape shape
    {
      get
      {
        return this.m_Shape;
      }
      set
      {
        this.m_Shape = value;
      }
    }

    /// <summary>
    ///   <para>Describes the area type of the NavMesh surface for this object.</para>
    /// </summary>
    public int area
    {
      get
      {
        return this.m_Area;
      }
      set
      {
        this.m_Area = value;
      }
    }

    /// <summary>
    ///   <para>Describes the object referenced for Mesh and Terrain types of input sources.</para>
    /// </summary>
    public Object sourceObject
    {
      get
      {
        return this.InternalGetObject(this.m_InstanceID);
      }
      set
      {
        this.m_InstanceID = !(value != (Object) null) ? 0 : value.GetInstanceID();
      }
    }

    /// <summary>
    ///   <para>Points to the owning component - if available, otherwise null.</para>
    /// </summary>
    public Component component
    {
      get
      {
        return this.InternalGetComponent(this.m_ComponentID);
      }
      set
      {
        this.m_ComponentID = !((Object) value != (Object) null) ? 0 : value.GetInstanceID();
      }
    }

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Component InternalGetComponent(int instanceID);

    [GeneratedByOldBindingsGenerator]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private extern Object InternalGetObject(int instanceID);
  }
}