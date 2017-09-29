﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// Control(widget) in OpenGL window.
    /// </summary>
    public abstract partial class GLControl
    {

        /// <summary>
        /// Parent control.
        /// </summary>
        public GLControl Parent { get; set; }

        private List<GLControl> children = new List<GLControl>();
        /// <summary>
        /// Children controls.
        /// </summary>
        public List<GLControl> Children { get { return this.children; } }

        /// <summary>
        /// Left distance to parent control.
        /// </summary>
        public int Left { get; set; }

        /// <summary>
        /// Bottom distance to parent control.
        /// </summary>
        public int Bottom { get; set; }

        /// <summary>
        /// Width of this control.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of this control.
        /// </summary>
        public int Height { get; set; }

        protected int absLeft;
        protected int absBottom;

        /// <summary>
        /// Layout for this control.
        /// </summary>
        public virtual void Layout()
        {
            GLControl parent = this.Parent;
            if (parent != null)
            {
                this.absLeft = parent.Left + this.Left;
                this.absBottom = parent.Bottom + this.Bottom;
            }
        }

        /// <summary>
        /// Who renders this control?
        /// </summary>
        public GLControlRendererBase Renderer { get; set; }

    }
}