package io.swagger.codegen.languages;

import io.swagger.codegen.CodegenType;
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
}
