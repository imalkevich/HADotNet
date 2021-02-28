﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HADotNet.Core.Clients
{
    /// <summary>
    /// Provides access to the template API for rendering Home Assistant templates.
    /// </summary>
    public sealed class TemplateClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateClient" />.
        /// </summary>
        /// <param name="instance">The Home Assistant base instance URL.</param>
        /// <param name="apiKey">The Home Assistant long-lived access token.</param>
        /// <param name="httpClient">The Http client.</param>
        public TemplateClient(Uri instance, string apiKey, HttpClient httpClient) : base(instance, apiKey, httpClient) { }

        /// <summary>
        /// Renders a template and returns the resulting output as a string.
        /// </summary>
        /// <returns>A string of the rendered template output.</returns>
        public async Task<string> RenderTemplate(string template) => await Post<string>("/api/template", new { template });
    }
}
