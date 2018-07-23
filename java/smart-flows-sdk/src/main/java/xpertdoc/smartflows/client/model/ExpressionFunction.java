/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * ExpressionFunction
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ExpressionFunction {
  @SerializedName("name")
  private String name = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("helpLink")
  private String helpLink = null;

  @SerializedName("categories")
  private List<String> categories = null;

  @SerializedName("varargs")
  private Boolean varargs = false;

  @SerializedName("arguments")
  private List<ExpressionFunctionArguments> arguments = null;

  public ExpressionFunction name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @ApiModelProperty(required = true, value = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public ExpressionFunction description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public ExpressionFunction helpLink(String helpLink) {
    this.helpLink = helpLink;
    return this;
  }

   /**
   * Get helpLink
   * @return helpLink
  **/
  @ApiModelProperty(value = "")
  public String getHelpLink() {
    return helpLink;
  }

  public void setHelpLink(String helpLink) {
    this.helpLink = helpLink;
  }

  public ExpressionFunction categories(List<String> categories) {
    this.categories = categories;
    return this;
  }

  public ExpressionFunction addCategoriesItem(String categoriesItem) {
    if (this.categories == null) {
      this.categories = new ArrayList<String>();
    }
    this.categories.add(categoriesItem);
    return this;
  }

   /**
   * Get categories
   * @return categories
  **/
  @ApiModelProperty(value = "")
  public List<String> getCategories() {
    return categories;
  }

  public void setCategories(List<String> categories) {
    this.categories = categories;
  }

  public ExpressionFunction varargs(Boolean varargs) {
    this.varargs = varargs;
    return this;
  }

   /**
   * Get varargs
   * @return varargs
  **/
  @ApiModelProperty(value = "")
  public Boolean isVarargs() {
    return varargs;
  }

  public void setVarargs(Boolean varargs) {
    this.varargs = varargs;
  }

  public ExpressionFunction arguments(List<ExpressionFunctionArguments> arguments) {
    this.arguments = arguments;
    return this;
  }

  public ExpressionFunction addArgumentsItem(ExpressionFunctionArguments argumentsItem) {
    if (this.arguments == null) {
      this.arguments = new ArrayList<ExpressionFunctionArguments>();
    }
    this.arguments.add(argumentsItem);
    return this;
  }

   /**
   * Get arguments
   * @return arguments
  **/
  @ApiModelProperty(value = "")
  public List<ExpressionFunctionArguments> getArguments() {
    return arguments;
  }

  public void setArguments(List<ExpressionFunctionArguments> arguments) {
    this.arguments = arguments;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ExpressionFunction expressionFunction = (ExpressionFunction) o;
    return Objects.equals(this.name, expressionFunction.name) &&
        Objects.equals(this.description, expressionFunction.description) &&
        Objects.equals(this.helpLink, expressionFunction.helpLink) &&
        Objects.equals(this.categories, expressionFunction.categories) &&
        Objects.equals(this.varargs, expressionFunction.varargs) &&
        Objects.equals(this.arguments, expressionFunction.arguments);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, description, helpLink, categories, varargs, arguments);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExpressionFunction {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    helpLink: ").append(toIndentedString(helpLink)).append("\n");
    sb.append("    categories: ").append(toIndentedString(categories)).append("\n");
    sb.append("    varargs: ").append(toIndentedString(varargs)).append("\n");
    sb.append("    arguments: ").append(toIndentedString(arguments)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

