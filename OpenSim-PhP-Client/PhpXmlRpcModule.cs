using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using log4net;
using MySql.Data.MySqlClient;
using Nini.Config;
using NSL.Certificate.Tools;
using NSL.Network.XmlRpc;
using Nwc.XmlRpc;
using OpenMetaverse;
using OpenSim.Data.MySQL.MySQLMoneyDataWrapper;
using OpenSim.Framework;
using OpenSim.Framework.Servers.HttpServer;
using OpenSim.Modules.Currency;
using OpenSim.Region.Framework.Scenes;
using OpenSim.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml;
using static Mono.Security.X509.X520;
using static OpenMetaverse.DllmapConfigHelper;
using OpenSim.Server.Base;
using OpenSim.Framework.Console;

// todo list:

// Wie in namespace OpenSim.Grid.MoneyServer, class MoneyXmlRpcModule die PHP Dateien abfangen und weiterverarbeiten.

// Url to search service
// SearchURL = "${Const|BaseURL}/search.php"

// For V3 destination guide
// DestinationGuide = "${Const|BaseURL}/guide.php"

// For V3 avatar picker (( work in progress ))
// AvatarPicker = "${Const|BaseURL}/avatars.php"

// login page: optional: if it exists it will be used to tell the client to use
// this as splash page
// welcome = ${ Const | BaseURL}/welcome.php

// web page of grid: optional: page providing further information about your grid
// about = ${ Const | BaseURL}/about.php

// account creation: optional: page providing further information about obtaining
// a user account on your grid
// register = ${ Const | BaseURL}/register.php

// help: optional: page providing further assistance for users of your grid
// help = ${ Const | BaseURL}/help.php

// password help: optional: page providing password assistance for users of your grid
// password = ${ Const | BaseURL}/password.php

// a http page for grid status
// GridStatus = ${ Const | BaseURL}/GridStatus.php
// a RSS page for grid status
// GridStatusRSS = ${ Const | BaseURL}/GridStatusRSS.php

// optional web page for profiles
// [AGENT_NAME] will be converted to Firstname.LastName by viewers
// web_profile_url = http://webprofilesurl:ItsPort?name=[AGENT_NAME]

// todo list end

namespace OpenSim.PhP.Client
{
    internal class PhpXmlRpcModule
    {
        private BaseHttpServer m_httpServer;


        public void Initialise()
        {
            RegisterStreamHandlers();
        }

        private void RegisterStreamHandlers()
        {
            // Registrierung für alle relevanten PHP-Endpunkte
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/search.php", PHPProcesssearch));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/guide.php", PHPProcessguide));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/avatars.php", PHPProcessavatars));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/welcome.php", PHPProcesswelcome));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/about.php", PHPProcessabout));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/register.php", PHPProcessregister));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/help.php", PHPProcesshelp));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/password.php", PHPProcesspassword));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/GridStatus.php", PHPProcessGridStatus));
            m_httpServer.AddSimpleStreamHandler(new SimpleStreamHandler("/GridStatusRSS.php", PHPProcessRSS));
        }

        public void PostInitialise()
        {
        }

        public void RegisterHandlers()
            {
        }


        private void PHPProcesssearch(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessguide(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessavatars(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcesswelcome(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessabout(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessregister(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcesshelp(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcesspassword(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessGridStatus(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }
        private void PHPProcessRSS(IOSHttpRequest httpRequest, IOSHttpResponse httpResponse)
        {
            // todo: Implement search functionality
        }

        public void UnregisterHandlers()
            {
        }
    }
}
