using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    public class Usuario
    {
        public String codigo;
        public String usuario;

        public String Codigos { get { return codigo; } set { codigo = value; } }
        public String Usuarios { get { return usuario; } set { usuario = value; } }

        public Usuario(String _codigo, String _usuario)
        {
            this.codigo = _codigo;
            this.usuario = _usuario;
        }
    }

    public class Blogs : Usuario
    {
        public String blogId;
        public String blogName;

        public String BlogId { get { return blogId; } set { blogId = value; } }
        public String BlogName { get { return blogName; } set { blogName = value; } }

        public Blogs(String _blogId, String _blogName, String _codigo, String _usuario): base(_codigo, _usuario)
        {
            this.blogId = _blogId;
            this.blogName = _blogName;
        }

    }
}
