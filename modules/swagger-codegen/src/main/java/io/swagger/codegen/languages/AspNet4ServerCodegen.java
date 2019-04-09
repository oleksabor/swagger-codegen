package io.swagger.codegen.languages;

import io.swagger.codegen.CodegenType;
import io.swagger.codegen.SupportingFile;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.io.File;

import static java.util.UUID.randomUUID;

public class AspNet4ServerCodegen extends AspNetCoreServerCodegen {

    private String packageGuid = "{" + randomUUID().toString().toUpperCase() + "}";

    protected boolean partialController = false;

    @SuppressWarnings("hiding")
    protected Logger LOGGER = LoggerFactory.getLogger(AspNetCoreServerCodegen.class);

    public AspNet4ServerCodegen() {
        super();

        outputFolder = "generated-code" + File.separator + this.getName();
    }

    public void setPackageGuid(String packageGuid) {
        this.packageGuid = packageGuid;
    }

    @Override
    public CodegenType getTag() {
        return CodegenType.SERVER;
    }

    @Override
    public String getName() {
        return "aspnet4";
    }

    @Override
    public String getHelp() {
        return "Generates an ASP.NET 4 Web API server.";
    }
    @Override
    public void processOpts() {
        super.processOpts();

        supportingFiles.clear();

        String packageFolder = sourceFolder + File.separator + packageName;

        supportingFiles.add(new SupportingFile("NuGet.Config", "", "NuGet.Config"));
        supportingFiles.add(new SupportingFile("build.sh.mustache", "", "build.sh"));
        supportingFiles.add(new SupportingFile("build.bat.mustache", "", "build.bat"));
        supportingFiles.add(new SupportingFile("README.mustache", "", "README.md"));
        supportingFiles.add(new SupportingFile("gitignore", packageFolder, ".gitignore"));

        supportingFiles.add(new SupportingFile("Program.mustache", packageFolder, "Program.cs"));
        supportingFiles.add(new SupportingFile("validateModel.mustache", packageFolder + File.separator + "Attributes", "ValidateModelStateAttribute.cs"));

        supportingFiles.add(new SupportingFile("fromHeader.mustache", packageFolder + File.separator + "Attributes", "FromHeaderAttribute.cs"));

        supportingFiles.add(new SupportingFile("Project.csproj.mustache", packageFolder, this.packageName + ".csproj"));

        //supportingFiles.add(new SupportingFile("Filters" + File.separator + "BasePathFilter.mustache", packageFolder + File.separator + "Filters", "BasePathFilter.cs"));
        //supportingFiles.add(new SupportingFile("Filters" + File.separator + "GeneratePathParamsValidationFilter.mustache", packageFolder + File.separator + "Filters", "GeneratePathParamsValidationFilter.cs"));
    }}
