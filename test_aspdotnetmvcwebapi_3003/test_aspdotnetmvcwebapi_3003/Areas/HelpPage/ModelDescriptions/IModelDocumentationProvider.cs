using System;
using System.Reflection;

namespace test_aspdotnetmvcwebapi_3003.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}