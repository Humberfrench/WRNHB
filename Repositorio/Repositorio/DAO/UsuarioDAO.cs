﻿using NHibernate;
using Repositorio.DAO.Generic;
using Repositorio.DAO.Interface;
using Repositorio.Entidades;

namespace Repositorio.DAO
{
    public class UsuarioDAO : GenericDAO<Usuario>, IUsuarioDAO
    {
        public UsuarioDAO(ISession session) : base(session) { }
    }
}
