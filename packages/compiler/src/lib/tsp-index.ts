import { TypeSpecDecorators } from "../../generated-defs/TypeSpec.js";
import {
  $deprecated,
  $discriminator,
  $doc,
  $encode,
  $encodedName,
  $error,
  $errorsDoc,
  $example,
  $format,
  $friendlyName,
  $inspectType,
  $inspectTypeName,
  $key,
  $knownValues,
  $list,
  $maxItems,
  $maxLength,
  $maxValue,
  $maxValueExclusive,
  $minItems,
  $minLength,
  $minValue,
  $minValueExclusive,
  $opExample,
  $overload,
  $parameterVisibility,
  $pattern,
  $projectedName,
  $returnTypeVisibility,
  $returnsDoc,
  $secret,
  $service,
  $summary,
  $tag,
  $visibility,
  $withDefaultKeyVisibility,
  $withOptionalProperties,
  $withPickedProperties,
  $withUpdateableProperties,
  $withVisibility,
  $withoutDefaultValues,
  $withoutOmittedProperties,
} from "./decorators.js";

/** @internal */
export const $decorators = {
  TypeSpec: {
    encode: $encode,
    doc: $doc,
    withOptionalProperties: $withOptionalProperties,
    withUpdateableProperties: $withUpdateableProperties,
    withoutOmittedProperties: $withoutOmittedProperties,
    withPickedProperties: $withPickedProperties,
    withoutDefaultValues: $withoutDefaultValues,
    withDefaultKeyVisibility: $withDefaultKeyVisibility,
    summary: $summary,
    returnsDoc: $returnsDoc,
    errorsDoc: $errorsDoc,
    deprecated: $deprecated,
    service: $service,
    error: $error,
    format: $format,
    pattern: $pattern,
    minLength: $minLength,
    maxLength: $maxLength,
    minItems: $minItems,
    maxItems: $maxItems,
    minValue: $minValue,
    maxValue: $maxValue,
    minValueExclusive: $minValueExclusive,
    maxValueExclusive: $maxValueExclusive,
    secret: $secret,
    // eslint-disable-next-line deprecation/deprecation
    list: $list,
    tag: $tag,
    friendlyName: $friendlyName,
    knownValues: $knownValues,
    key: $key,
    overload: $overload,
    projectedName: $projectedName,
    encodedName: $encodedName,
    discriminator: $discriminator,
    example: $example,
    opExample: $opExample,
    visibility: $visibility,
    withVisibility: $withVisibility,
    inspectType: $inspectType,
    inspectTypeName: $inspectTypeName,
    parameterVisibility: $parameterVisibility,
    returnTypeVisibility: $returnTypeVisibility,
  } satisfies TypeSpecDecorators,
};

// Projection function exports
export const namespace = "TypeSpec";
export { getProjectedName, hasProjectedName } from "./decorators.js";
